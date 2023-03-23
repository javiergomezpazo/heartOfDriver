using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PacenoteImage : MonoBehaviour
{

    private const string PACENOTE_D6 = "D6",
    PACENOTE_I6 = "I6",
    PACENOTE_D5 = "D5",
    PACENOTE_I5 = "I5",
    PACENOTE_D4 = "D4",
    PACENOTE_I4 = "I4",
    PACENOTE_D3 = "D3",
    PACENOTE_I3 = "I3",
    PACENOTE_D2 = "D2",
    PACENOTE_I2 = "I2",
    PACENOTE_D1 = "D1",
    PACENOTE_I1 = "I1";

    public Image pacenoteImage;
    private string pacenote;

    public Sprite pacenoteSprite_D6,
        pacenoteSprite_I6,
        pacenoteSprite_D5,
        pacenoteSprite_I5,
        pacenoteSprite_D4,
        pacenoteSprite_I4,
        pacenoteSprite_D3,
        pacenoteSprite_I3,
        pacenoteSprite_D2,
        pacenoteSprite_I2,
        pacenoteSprite_D1,
        pacenoteSprite_I1;
    // Start is called before the first frame update
    void Start()
    {

        pacenoteImage.enabled = false;

    }


    public IEnumerator changePacenoteImage()
    {
        Debug.Log("rrr444444");
        Sprite sprite_aux = null;

        switch (pacenote)
        {
            case PACENOTE_D6:
                sprite_aux = pacenoteSprite_D6;
                break;
            case PACENOTE_I6:
                sprite_aux = pacenoteSprite_I6;
                break;
            case PACENOTE_D5:
                sprite_aux = pacenoteSprite_D5;
                break;
            case PACENOTE_I5:
                sprite_aux = pacenoteSprite_I5;
                break;
            case PACENOTE_D4:
                sprite_aux = pacenoteSprite_D4;
                break;
            case PACENOTE_I4:
                sprite_aux = pacenoteSprite_I4;
                break;
            case PACENOTE_D3:
                sprite_aux = pacenoteSprite_D3;
                break;
            case PACENOTE_I3:
                sprite_aux = pacenoteSprite_I3;
                break;
            case PACENOTE_D2:
                sprite_aux = pacenoteSprite_D2;
                break;
            case PACENOTE_I2:
                sprite_aux = pacenoteSprite_I2;
                break;
            case PACENOTE_D1:
                sprite_aux = pacenoteSprite_D1;
                break;
            case PACENOTE_I1:
                sprite_aux = pacenoteSprite_I1;
                break;

        }

        if (sprite_aux != null)
        {
            pacenoteImage.sprite = sprite_aux;
            pacenoteImage.enabled = true;
        }
        yield return new WaitForSecondsRealtime(5);
        pacenoteImage.enabled = false;

    }

    public void setPacenote(string pacenote)
    {
        Debug.Log("rrr333");
        this.pacenote = pacenote;
        StartCoroutine(changePacenoteImage());
    }

}
