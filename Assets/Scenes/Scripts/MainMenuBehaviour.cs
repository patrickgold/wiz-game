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

    public void LevelTestButton__OnClick() {
        Debug.Log("Loading scene LevelTest.");
        SceneManager.LoadScene("LevelTest", LoadSceneMode.Single);
    }

    public void SettingsButton__OnClick() {
        Debug.Log("Loading scene Settings.");
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }

    public void QuitButton__OnClick() {
        // Save game data

        // Close application
        Debug.Log("Quitting WizGame!");
        Application.Quit();
    }
}
