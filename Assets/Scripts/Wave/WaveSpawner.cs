using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform[] enemyPrefabs;

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

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = ("Next Wave:" + Mathf.Round(countdown).ToString());              //Makes TMP Show the Next wave text with a countdown from timer
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);           //Spawns enemies 0.5 seconds between each so it they dont collide
        }

        waveIndex++;
    }

    void SpawnEnemy()
    {
        int wave = waveIndex - 1;
        int enemyIndex = Random.Range(0, Mathf.Clamp(wave, 0, enemyPrefabs.Length));          //Picks random enemy from list chooses
        Instantiate(enemyPrefabs[enemyIndex], spawnPoint.position, spawnPoint.rotation);
    }
}
