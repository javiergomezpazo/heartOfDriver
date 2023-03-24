using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public string scene;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    public void LoadScene()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

}
