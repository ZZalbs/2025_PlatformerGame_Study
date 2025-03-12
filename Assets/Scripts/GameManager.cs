using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//6강 : 
public class GameManager : MonoBehaviour
{
    //6강
    public TMP_Text scoreText;
    public TMP_Text gameEndText;
    public GameObject gameEndUI;

    private int coinScore;

    void Start()
    {
        gameEndUI.SetActive(false);
        coinScore = 0;
    }

    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        coinScore++;
        scoreText.text = "점수 : " + coinScore.ToString();
    }

    public void GameClear()
    {
        gameEndUI.SetActive(true);
        gameEndText.text = "Game Clear!";
        Time.timeScale = 0.0f;
    }
    public void GameOver()
    {
        gameEndUI.SetActive(true);
        gameEndText.text = "Game Over!";
        Time.timeScale = 0.0f;
    }
}
