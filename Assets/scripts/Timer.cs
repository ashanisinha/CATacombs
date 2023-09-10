using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float gameDurationSeconds = 240f;
    private float timer;

    private void Start()
    {
        timer = 0f; // Initialize the timer to zero
    }

    private void Update()
    {
        // Increment the timer by the time passed since the last frame
        timer += Time.deltaTime;

        // Check if game is over
        if (timer >= gameDurationSeconds)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        //SceneManager.LoadScene("DeathScene");
    }
}
