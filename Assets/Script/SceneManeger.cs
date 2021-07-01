using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManeger : MonoBehaviour
{
    private void Update()
    {
       
    }
    public void ChangeScene(int sceneNo)
    {
        SceneManager.LoadScene(sceneNo);
    }

    public void quitApp()
    {

        Application.Quit();
    }
}
