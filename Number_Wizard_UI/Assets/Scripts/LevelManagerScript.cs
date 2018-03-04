using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{

    public void loadNextLevel()
    {
        Debug.Log("Level load requested" + name);
        // Application.LoadLevel(1);-- old method to call scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);// new method to call scene

    }

    public void loadPreviusLevel()
    {
        Debug.Log("Level load requested" + name);
        // Application.LoadLevel(1);-- old method to call scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);// new method to call scene

    }

    public void EndGame(string name)
    {
        SceneManager.LoadScene(name);
    }



    public void quitGame()
    {
        Debug.Log("Level quit requested");
        Application.Quit();//-- exit application works only on PC games
    }

}
