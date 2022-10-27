using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    // public Transform positionToSpawn, positionForVector;
    // private Rigidbody2D rb;
    // public float flightSpeed = 100f, 
    public float lifetime = 3f, timer = 0f;
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    //     transform.rotation = FindObjectOfType<Player>().transform.rotation;
    //     rb.velocity = new Vector3(positionToSpawn.position.x - positionForVector.position.x, 
    //         positionToSpawn.position.y - positionForVector.position.y,- 0) * flightSpeed * Time.deltaTime;
    // }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= lifetime)
        {
            Destroy(bullet);
        }
    }
}
