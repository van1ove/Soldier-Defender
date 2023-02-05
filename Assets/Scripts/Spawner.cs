using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] static int size;
    public Transform followPoint;
    public Transform[] spawnPoints = new Transform[size];
    private float delay = 1f;
    private Vector3 spawnVector;
    private Quaternion spawnRotation;
    private int position;
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while(true)
        {
            position = Random.Range(0, spawnPoints.Length - 1);
            spawnVector = spawnPoints[position].transform.position;
            spawnRotation = spawnPoints[position].rotation;

            Instantiate(enemy, spawnVector, spawnRotation);
            yield return new WaitForSeconds(delay);
        }
    }
}
