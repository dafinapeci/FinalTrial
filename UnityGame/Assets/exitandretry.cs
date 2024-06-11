using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitandretry : MonoBehaviour
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
        if (currentSceneName == "Level1")
        {
            SceneManager.LoadSceneAsync("Level1");
        }
        if (currentSceneName == "Level3")
        {
            SceneManager.LoadSceneAsync("Level3");
        }
        if (currentSceneName == "Level5")
        {
            SceneManager.LoadSceneAsync("Level5");
        }
        if (currentSceneName == "Level2")
        {
            SceneManager.LoadSceneAsync("Level2");
        }
        if (currentSceneName == "level4")
        {
            SceneManager.LoadSceneAsync("level4");
        }
        if (currentSceneName == "level6")
        {
            SceneManager.LoadSceneAsync("level6");
        }
    }
}
