using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pacenotes : MonoBehaviour
{



    public string pacenote;


    private void OnTriggerEnter2D(Collider2D collision)
    {


                Debug.Log("rrr222");

                GameObject.Find("Pacenote").SendMessage("setPacenote", pacenote);
                
    }




}
