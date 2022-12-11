using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public int score;

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();

    }


    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
