using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuUIController : Button
{

    private const string MENU_SHAKEDOWN = "MENU_SHAKEDOWN",
        MENU_HISTORYMODE = "MENU_HISTORYMODE",
        MENU_SETTINGS = "MENU_SETTINGS",
        MENU_SHOP = "MENU_SHOP",
        MENU_MULTIPLAYER = "MENU_MULTIPLAYER";

    public string typeAction;

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        switch (typeAction)
        {
            case MENU_SHAKEDOWN:
                break;
        }
    }
}
