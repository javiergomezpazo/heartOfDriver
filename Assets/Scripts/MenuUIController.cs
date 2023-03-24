using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuUIController : MonoBehaviour
{

    private const string BUTTON_SHAKEDOWN = "BUTTON_SHAKEDOWN",
        BUTTON_HISTORYMODE = "BUTTON_HISTORYMODE",
        BUTTON_SETTINGS = "BUTTON_SETTINGS",
        BUTTON_SHOP = "BUTTON_SHOP",
        BUTTON_MULTIPLAYER = "BUTTON_MULTIPLAYER",
        BUTTON_SELECT_STAGE = "BUTTON_SELECT_STAGE",
        BUTTON_START_GAME = "BUTTON_START_GAME",
        BUTTON_BACK = "BUTTON_BACK";

    private const string VIEW_SHAKEDOWN = "VIEW_SHAKEDOWN",
        VIEW_SELECT_STAGE = "VIEW_SELECT_STAGE",
        VIEW_SELECT_CAR = "VIEW_SELECT_CAR";


    public GameObject view_MainMenu;
    public GameObject view_SelectStage;
    public GameObject view_SelectCar;

    public string typeButton;
    public Button button;
    public GameObject buttonBack;
    public TextMeshProUGUI tittleText;

	void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate () { clickButton(); });
    }
   

    public void clickButton()
    {
        Debug.Log("ggggggggggggg");
        switch (typeButton)
        {
            case BUTTON_SHAKEDOWN:
                changeMenuView(VIEW_SELECT_STAGE);
                break;
            case BUTTON_SELECT_STAGE:
                changeMenuView(VIEW_SELECT_CAR);
                break;
            case BUTTON_START_GAME:
                SceneController sceneController = new SceneController();
                sceneController.scene = "Track_Test";
                sceneController.LoadScene();
                break;
        }


    }

    private void changeMenuView(string type_action)
    {
        switch (type_action)
        {
            case VIEW_SELECT_STAGE:
                Debug.Log("ggggggggggggg");
                view_MainMenu.SetActive(false);
                view_SelectStage.SetActive(true);
                buttonBack.SetActive(true);
                tittleText.SetText("Tramos");
                break;
            case VIEW_SELECT_CAR:
                view_SelectStage.SetActive(false);
                view_SelectCar.SetActive(true);
                tittleText.SetText("Vehículos");
                break;

        }


    }

}
