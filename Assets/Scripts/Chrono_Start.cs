using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chrono_Start : MonoBehaviour
{
    public CarController carController;
    public Image chronoStart;
    public Sprite sprite_chronoStart05;
    public Sprite sprite_chronoStart04;
    public Sprite sprite_chronoStart03;
    public Sprite sprite_chronoStart02;
    public Sprite sprite_chronoStart01;
    public Sprite sprite_chronoStart00;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("xx m22eeeeeee");
        carController.enabled = false;
        StartCoroutine(waiter());
        Debug.Log("xx m33eeeeeee");
    }

    // Update is called once per frame
    private IEnumerator waiter()
    {
        Debug.Log("xx meeeeeeeeeeeee");

        ArrayList sprites = new ArrayList()
        {
            sprite_chronoStart05,
            sprite_chronoStart04,
            sprite_chronoStart03,
            sprite_chronoStart03,
            sprite_chronoStart02,
            sprite_chronoStart01,
            sprite_chronoStart00
        };

        var num = 1;
        var timeWait = 1;

        foreach(Sprite sprite in sprites)
        {

            
            chronoStart.sprite = sprite;
            if (sprites.Count == num)
            {
                timeWait = 2;
                carController.enabled = true;
                GameObject.Find("Text_TimeTrack").SendMessage("Started");
            }
            num++;
            yield return new WaitForSecondsRealtime(timeWait);
        }
        chronoStart.enabled = false;
        Debug.Log("xx rrrr");
    }
}
