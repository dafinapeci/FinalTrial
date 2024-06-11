using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamenames : MonoBehaviour
{
    string currentSceneName;
    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync("mainMenu");
        }
    }
    public void back()
    {
        SceneManager.LoadSceneAsync("mainMenu");
    }

    public void restart()
    {
        if (currentSceneName == "1stwinscene")
        {
            SceneManager.LoadSceneAsync("Level1");
        }
        if (currentSceneName == "3stwinscene 2")
        {
            SceneManager.LoadSceneAsync("Level3");
        }
        if (currentSceneName == "5stwinscene 4")
        {
            SceneManager.LoadSceneAsync("Level5");
        }
        if (currentSceneName == "2stwinscene 1")
        {
            SceneManager.LoadSceneAsync("Level2");
        }
        if (currentSceneName == "4stwinscene 3")
        {
            SceneManager.LoadSceneAsync("level4");
        }
        if (currentSceneName == "6stwinscene 5")
        {
            SceneManager.LoadSceneAsync("level6");
        }
    }
}
