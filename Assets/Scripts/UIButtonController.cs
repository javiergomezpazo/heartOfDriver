using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIButtonController : Button
{

    private const string BRAKE = "BRAKE",
        ACCELERATE="ACCELERATE",
        DIRECTION_LEFT = "DIRECTION_LEFT",
        DIRECTION_RIGHT = "DIRECTION_RIGHT";

    private const string CARCONTROLLER = "CARCONTROLLER";

    public string typeAction;
    public string typeButton;

    private void OnSendCarController(bool valueZero=false)
    {
        Debug.Log("nnnn22");
        try
        {
            switch (typeAction)
            {
                case BRAKE:
                    GameObject.Find("Car").SendMessage("setAcelarationBrake", valueZero ? 0:- 1);
                    break;
                case ACCELERATE:
                    GameObject.Find("Car").SendMessage("setAcelarationBrake", valueZero ? 0:1);
                    break;
                case DIRECTION_LEFT:
                    GameObject.Find("Car").SendMessage("setDirection", valueZero ? 0:-1);
                    break;
                case DIRECTION_RIGHT:
                    GameObject.Find("Car").SendMessage("setDirection", valueZero ? 0:1);
                    break;
            }
        }
        catch(System.NotImplementedException implEx)
        {

        }catch(System.Exception ex)
        {

        }

    }


    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        switch (typeButton)
        {
            case CARCONTROLLER:
                OnSendCarController();
                break;
        }
    }

    // Button is released
    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);

        switch (typeButton)
        {
            case CARCONTROLLER:
                OnSendCarController(true);
                break;
        }

    }

}
