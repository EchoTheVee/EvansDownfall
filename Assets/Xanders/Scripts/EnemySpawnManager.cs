using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 7;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(EnemySpawn());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator EnemySpawn()
    {
        yield return new WaitForSeconds(3);
        float spawnPosY = Random.Range(-spawnRange, spawnRange);
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        Vector2 randomPos = new Vector2(spawnPosY, spawnPosX);
        Instantiate(enemyPrefab, randomPos, enemyPrefab.transform.rotation);
        StartCoroutine(EnemySpawn());
    }
}
