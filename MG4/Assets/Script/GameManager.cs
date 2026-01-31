using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool IsPlaying { get; private set; } = true;
    public int Score { get; private set; } = 0;

    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private AudioClip scoreSfx;
    [SerializeField] private AudioClip deathSfx;

    private AudioSource audioSource; 

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        audioSource = GetComponent<AudioSource>(); 
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

        if (scoreSfx != null && audioSource != null)
        {
            audioSource.PlayOneShot(scoreSfx);
        }
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + Score; 
        }
    }

    public void GameOver()
    {
        if (!IsPlaying) return;

        IsPlaying = false;
        Debug.Log("Game Over");

        if (deathSfx != null && audioSource != null)
        {
            audioSource.PlayOneShot(deathSfx);
        }

        Time.timeScale = 0f;
    }
}
