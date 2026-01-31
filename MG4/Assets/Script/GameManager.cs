using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool IsPlaying{get;private set;}=true;
    public int Score{get; private set; }=0;
    [SerializeField] private TMP_Text ScoreText;
    private void Awake()
    {
        if (Instance != null && Instance != this)
    {
    Destroy(gameObject);
    return;
    }

Instance = this;
    }
 private void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int amount)
    {
        if (!IsPlaying) return;

        Score += amount;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (ScoreText != null)
        {
            ScoreText.text = "Score:"+Score;
        }
    }

    public void GameOver()
    {
        if (!IsPlaying) return;

        IsPlaying = false;
        Debug.Log("Game Over");

        Time.timeScale = 0f;
        }

}