using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2.5f;
    [SerializeField] private float destroyX = -15f;

    private void Update()
    {
        if (!GameManager.Instance.IsPlaying) return;

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}