using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader1 : MonoBehaviour
{
    public void LoadScene1(string sceneName)
    {
        SceneManager.LoadScene("loginScene");
    }
}
