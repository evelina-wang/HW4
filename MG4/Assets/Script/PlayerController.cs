using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float flapVelocity = 5f;

    [Header("Audio")]
    [SerializeField] private AudioClip flapSfx;

    private Rigidbody2D rb;
    private AudioSource audioSource;

    private bool isAlive = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!isAlive) return;
        if (!GameManager.Instance.IsPlaying) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Flap();
        }
    }

    private void Flap()
    {
        rb.velocity = new Vector2(rb.velocity.x, flapVelocity);

        if (flapSfx != null && audioSource != null)
        {
            audioSource.PlayOneShot(flapSfx);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isAlive) return;

        isAlive = false;
        GameManager.Instance.GameOver();
    }
}
