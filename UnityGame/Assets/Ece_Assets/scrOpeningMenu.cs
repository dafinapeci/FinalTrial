using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrOpeningMenu : MonoBehaviour
{
    private void Update()
    {
        //�al���rken herhangi bir kodun aktifle�mesi bu sayfada gerekmez
    }
    public void Signin(string gameName)
    {
        SceneManager.LoadSceneAsync("signinScene");
    }
    public void quitgame(string gameName)
    {
        Application.Quit();
    }
    public void LogIN()
    {
        SceneManager.LoadSceneAsync("loginScene");
    }
    public void ToMainMenu(string gameName)
    {
        SceneManager.LoadSceneAsync("mainMenu");
    }
    public void aktarma()
    {
        SceneManager.LoadSceneAsync("forgetPassword");
    }

}