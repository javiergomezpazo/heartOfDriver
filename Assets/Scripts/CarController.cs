using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;

    public float driftCar = 0.85f;
    public float accelerationFactor = 300.4f;
    public float turnFactor = 2.8f;
    public float maxSpeed = 180f;

    float accelerationInput = 0;
    float velocityUp = 0;
    float steeringInput = 0;
    
    float rotationAngle = 0;

    AudioController audioController;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        audioController = FindObjectOfType<AudioController>();

    }


    private void FixedUpdate()
    {
        applySteering();
        killOrthogonalVelocity();
        applyEngineForce();
    }


    void applySteering()
    {
        rotationAngle -= steeringInput * turnFactor * Mathf.Clamp01((rigidbody2D.velocity.magnitude / 8));

        rigidbody2D.MoveRotation(rotationAngle);

    }

    bool applyEngineForce()
    {

        velocityUp = Vector2.Dot(transform.up, rigidbody2D.velocity);

        audioController.playSound(velocityUp);

        if ((velocityUp < -maxSpeed * 0.5f && accelerationInput < 0)
            || (velocityUp > maxSpeed  && accelerationInput > 0))
        {
            return true;
        }

        if(rigidbody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
        {
            return true;
        }

        if(accelerationInput == 0)
        {
            rigidbody2D.drag = Mathf.Lerp(rigidbody2D.drag, 3.0f, Time.fixedDeltaTime * 3);
        }
        else
        {
            rigidbody2D.drag = rigidbody2D.drag-20;
        }


        Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

        rigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);

        return true;
    }

    void killOrthogonalVelocity()
    {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(rigidbody2D.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(rigidbody2D.velocity, transform.right);

        rigidbody2D.velocity = forwardVelocity + rightVelocity * driftCar;
    }

    public void setInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }

    public bool isTireDrift()
    {
        float lateralVelocity = Vector2.Dot(transform.right, rigidbody2D.velocity);
        bool braking = false;

        if (accelerationInput < 0 && velocityUp > 0)
        {
            braking = true;
        }

        if (Mathf.Abs(lateralVelocity) > 4.0f)
        {
            braking = true;
        }

        return braking;
    }

}
