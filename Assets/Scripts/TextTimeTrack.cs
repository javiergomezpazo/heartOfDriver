using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextTimeTrack : MonoBehaviour
{

    public TextMeshProUGUI text;
    float timeTrack;
    private bool finnished = false;
    private bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        timeTrack = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finnished && started)
        {
            timeTrack = Time.time - timeTrack;
            TimeSpan timeSpan = TimeSpan.FromSeconds(timeTrack);
            text.text = string.Format("{0:D2}:{1:D2}.{2:D3}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            Debug.Log("vvv" + timeTrack.ToString());
        }
        
    }

    public void Finneshed()
    {
        finnished=true;

        //Show View Finish

        GameObject.Find("FinishGame").SendMessage("showView", (System.Object) text.text);

    }
    
    public void Started()
    {
        started = true;
    }

}
