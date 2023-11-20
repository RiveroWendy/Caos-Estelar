using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TimerController timerController; // Reference to your TimerController script
    public PuntajeData puntajeData; // Reference to your PuntajeData scriptable object

    private void Start()
    {
        DisplayScore();
    }

    public void CalculateScore()
    {
        // Calculate the score based on the time taken
        float timeTaken = timerController.totalTime - timerController.getCurrentTime();

        // You can adjust the scoring formula based on your game's requirements
        int score = Mathf.RoundToInt(1000 / timeTaken); // Adjust this formula as needed

        // Save the score to the PuntajeData scriptable object
        puntajeData.SetPuntaje(score);
    }

    void DisplayScore()
    {
        // Display the score in the UI
        scoreText.text = $"{puntajeData.GetPuntaje()}";
    }
}