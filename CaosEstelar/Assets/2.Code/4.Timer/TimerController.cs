using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float totalTime = 60f; // Set your desired initial time here
    private float currentTime;
    private bool isGamePaused = false;

    private bool timerActive = true;

    void Start()
    {
        currentTime = totalTime;
    }

    public float getCurrentTime()
    {
        return currentTime;
    }
    void Update()
    {
        if (!isGamePaused && timerActive)
        {
            UpdateTimer();
        }

        // Reload level if the timer reaches 0
        if (currentTime <= 0f)
        {
            ReloadLevel();
        }
    }
    public void PauseGame()
    {
        isGamePaused = true;
    }
    void UpdateTimer()
    {
        currentTime -= Time.deltaTime;
        DisplayTime();
    }

    void DisplayTime()
    {
        string seconds = (currentTime % 60).ToString("00");

        // Update the TextMeshPro text
        timerText.text = $"{seconds}";
    }

    void ReloadLevel()
    {
  
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        timerActive = false;
    }
}
