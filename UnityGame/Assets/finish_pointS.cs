using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish_pointS : MonoBehaviour
{
    public Timer1 timer; // Reference to the Timer script
    string currentSceneName;
    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Stop player movement
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
                rb.velocity = Vector2.zero;

            // Notify player movement script
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.ReachFinishPoint();
                if (currentSceneName == "Level2")
                {
                    SceneManager.LoadSceneAsync("2stwinscene 1");
                }
                if (currentSceneName == "level4")
                {
                    SceneManager.LoadSceneAsync("4stwinscene 3");
                }
                if (currentSceneName == "level6")
                {
                    SceneManager.LoadSceneAsync("6stwinscene 5");
                }
            }

            // Stop the timer
            if (timer != null)
            {
                float finalTime = timer.StopTimer();
                Debug.Log("Timer stopped at " + finalTime);
            }
            else
            {
                Debug.LogError("Timer reference is missing.");
            }
        }
    }
}
