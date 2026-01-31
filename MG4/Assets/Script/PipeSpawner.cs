using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;   
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private float spawnX = 10f;
    [SerializeField] private float minY = -2f;
    [SerializeField] private float maxY = 2f;

    private float timer = 0f;

    private void Update()
 {
        if (!GameManager.Instance.IsPlaying) return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnPipe();
        }
    }

    private void SpawnPipe()
    {
        float y = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, y, 0f);

        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}



