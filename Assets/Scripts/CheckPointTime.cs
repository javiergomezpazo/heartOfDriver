using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTime : MonoBehaviour
{

    private const string TYPE_START = "START",
        TYPE_FINISHED = "FINISHED",
        TYPE_CHECKPOINT = "CHECKPOINT";

    public string type;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        switch (type)
        {
            case TYPE_START:

                break;
            case TYPE_FINISHED:

                Debug.Log("ggg222");

                GameObject.Find("Text_TimeTrack").SendMessage("Finneshed");
                GameObject.Find("Car").SendMessage("StopCarController");
                break;
        }
    }


}
