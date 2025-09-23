using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    [SerializeField] private GameObject bananaPrefab;
    [SerializeField] private Transform[] spawnPoints;

    private void Start()
    {
        SpawnItems(applePrefab, 5);
        SpawnItems(bananaPrefab, 7);
    }

    private void SpawnItems(GameObject prefab, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Transform point = spawnPoints[randomIndex];

            Instantiate(prefab, point.position, Quaternion.identity);
        }
    }
}