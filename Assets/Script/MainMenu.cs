using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void ChangeScene(string Scene)
    {
        if (Scene == "Level 2")
        {
            Score.cookies = 0;
        }
        SceneManager.LoadScene(Scene);
    }
 
    public void quit()
    {
        Application.Quit();
        Debug.Log("quited!");
    }
    
}
