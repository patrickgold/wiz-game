using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button__LevelTest__OnClick() {
        Debug.Log("Loading scene LevelTest.");
        SceneManager.LoadScene("LevelTest", LoadSceneMode.Single);
    }

    public void Button__Quit__OnClick() {
        // Save game data

        // Close application
        Debug.Log("Quitting WizGame!");
        Application.Quit();
    }
}
