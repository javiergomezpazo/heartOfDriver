using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FinishViewGame : MonoBehaviour
{

    public GameObject finishGame;
    public TextMeshProUGUI timeText;
    public Button continueButton;

    // Start is called before the first frame update
    void Start()
    {


    }

    private void clickButton()
    {

        SceneController sceneController = new SceneController();
        sceneController.scene = "MainMenu";
        sceneController.LoadScene();
    }

    public void showView(System.Object time)
    {

        Debug.Log("xxxxxxxxxxxxxxvvv");
        GameObject.Find("Canvas_InGame").SetActive(false);
        finishGame.SetActive(true);
        timeText.SetText((string) time);
        continueButton.onClick.AddListener(delegate () { clickButton(); });

    }
    
}
