using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aramenucuk : MonoBehaviour
{
    public GameObject aramenu;

    bool isPaused;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        if (isPaused)
        {
            Time.timeScale = 0;
            aramenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            aramenu.SetActive(false);
        }
    }

    public void resumebutton()
    {
        isPaused = false;
    }
    public void mainmenusbutton()
    {
        SceneManager.LoadScene(0);
    }
    public void quittbutton()
    {
        Application.Quit();
    }




}