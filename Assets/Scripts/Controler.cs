using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{

    CarController carController;

    private Vector2 axisVector;
    private bool isMobileController = false;

   

    // Start is called before the first frame update
    void Start()
    {
        axisVector = Vector2.zero;
        carController = GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (!isMobileController)
        {
            axisVector.x = Input.GetAxisRaw("Horizontal");
            axisVector.y = Input.GetAxisRaw("Vertical");
        }

        Debug.Log("pp: " + Input.GetAxisRaw("Horizontal"));


        carController.setInputVector(axisVector);


    }

    public void setAcelarationBrake(float value)
    {
        axisVector.y = value;
    }

    public void setDirection(float value)
    {
        axisVector.x = value;
    }

    public void StopCarController()
    {
        axisVector.y = 0;
        axisVector.x = 0;
        carController.enabled = false;
    }

}
