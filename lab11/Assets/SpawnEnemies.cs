using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int numberOfEnemies = 10;
    public float spawnRadius = 20f;

    void Start()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-spawnRadius, spawnRadius), 0, Random.Range(-spawnRadius, spawnRadius));
            Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(enemyPrefab, randomPosition, randomRotation);
        }
    }
}