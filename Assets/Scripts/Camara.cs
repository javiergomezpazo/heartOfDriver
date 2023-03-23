using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public GameObject mainCar;

    
    void Update()
    {
        Vector3 position = transform.position;
        
        position.x = mainCar.transform.position.x;
        position.y = mainCar.transform.position.y;

        transform.SetPositionAndRotation(position, transform.rotation);
    }
}
