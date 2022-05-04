using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bscript : MonoBehaviour
{

    public void mainMenuButton()
    {

        SceneManager.LoadScene(0);
        Debug.Log("ana menuye dondu");

    }

    public void quitikiButton()
    {

        Application.Quit();
        Debug.Log("oyundan cýktý");

    }


    public void contineMenuButton()
    {
      
        SceneManager.LoadScene(1);
        Debug.Log("oyuna devam etti");
    }
}
