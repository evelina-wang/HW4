using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private bool scored = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (scored) return;
        if (!GameManager.Instance.IsPlaying) return;

        if (other.CompareTag("Player"))
        {
            scored = true;
            GameManager.Instance.AddScore(1);
        }
    } 
}
