using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Button__LevelTest__OnClick() {

    }

    public void Button__Quit__OnClick() {
        // Save game data

        // Close application
        Debug.Log("Quitting WizGame!");
        Application.Quit();
    }
}
