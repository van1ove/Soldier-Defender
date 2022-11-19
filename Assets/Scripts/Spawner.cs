using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    public Transform followPoint;
    public Transform[] spawnPoints = new Transform[13];
    private float timer, angle, totalAngle; 
    private float spawnTime = 1f;
    private Vector3 spawnVector, followVector;
    private int position;
    void Start()
    {
        timer = spawnTime;
    }
    void Update()
    {
        if(timer <= 0)
        {
            position = Random.Range(0, spawnPoints.Length - 1);
            spawnVector = spawnPoints[position].transform.position;
            followVector = followPoint.transform.position;

            angle = 180 * Mathf.Atan((spawnVector.y - followVector.y) / (spawnVector.x - followVector.x)) / Mathf.PI;
            if(angle == float.PositiveInfinity) totalAngle = -90;
            else if (angle < 0) totalAngle = -90 + angle;
            else totalAngle = 90 + angle;
            
            Instantiate(enemy, spawnVector, Quaternion.Euler(0, 0, totalAngle));
            timer = spawnTime;
        }
        timer -= Time.deltaTime; 
    }
}
