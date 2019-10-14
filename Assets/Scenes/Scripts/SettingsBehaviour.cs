using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMainMenuButton__OnClick() {
        Debug.Log("Going back to MeinMenu.");
        SceneManager.LoadScene("MainMenu");
    }
}
