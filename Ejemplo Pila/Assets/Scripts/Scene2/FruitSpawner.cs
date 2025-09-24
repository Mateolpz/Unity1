using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bananaPrefab;
    public Transform[] spawnPoints;

    public int appleCount = 5;
    public int bananaCount = 7;

    void Start()
    {
        SpawnFruits();
    }

    void SpawnFruits()
    {
        // Copiamos los spawnPoints en una lista para ir quitándolos
        List<Transform> availablePoints = new List<Transform>(spawnPoints);

        // Generar manzanas
        for (int i = 0; i < appleCount && availablePoints.Count > 0; i++)
        {
            int randomIndex = Random.Range(0, availablePoints.Count);
            Transform spawnPoint = availablePoints[randomIndex];

            Instantiate(applePrefab, spawnPoint.position, Quaternion.identity);

            // Quitamos ese punto para que no se repita
            availablePoints.RemoveAt(randomIndex);
        }

        // Generar bananas
        for (int i = 0; i < bananaCount && availablePoints.Count > 0; i++)
        {
            int randomIndex = Random.Range(0, availablePoints.Count);
            Transform spawnPoint = availablePoints[randomIndex];

            Instantiate(bananaPrefab, spawnPoint.position, Quaternion.identity);

            // Quitamos ese punto también
            availablePoints.RemoveAt(randomIndex);
        }
    }
}