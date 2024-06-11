using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader2 : MonoBehaviour
{
    public void LoadScene2(string sceneName)
    {
        SceneManager.LoadScene("mainMenu");
    }
}
