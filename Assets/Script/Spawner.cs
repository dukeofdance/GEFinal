using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spawner : MonoBehaviour
{
    public GameObject duck;

    public float minX, maxX;
    public float minY, maxY;

    public int enemyLimit;

    public float spawnTime=3;
    private float timer = 0;
    private float TotalTime = 0;
    private float endTime = 20;
    private Vector3 randomPosition;
    // Start is called before the first frame update
    void Update()
    {
        randomPosition = new Vector3(Random.Range(minX, maxX), 1f, Random.Range(minY, maxY));
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            TotalTime += timer;
            timer = 0;
            SpawnDuck();
        }
        if (TotalTime >= endTime)
        {
            SceneManager.LoadScene("Win");
        }

    }

    void SpawnDuck()
    {
        var duck = DuckPool.Instance.GetFromPool();
        duck.transform.position = randomPosition;

    }


}
