using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab1;
    //These are the prefabs for the enemies we will use
    //public Transform enemyPrefab2;
    //public Transform enemyPrefab3;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public  TMP_Text waveCountdownText;

    private int waveIndex = 0;

    void Update()
    {
        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        waveCountdownText.text = ("Next Wave:" + Mathf.Round(countdown).ToString());
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            //Spawns enemies 0.5 seconds between each so it they dont collide
            yield return new WaitForSeconds(0.5f);
        }

        waveIndex++;
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab1, spawnPoint.position, spawnPoint.rotation);
    }
}
