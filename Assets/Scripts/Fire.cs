using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform positionToSpawn;
    public bool isDown = false;
    public float delay = 0.3f, bulletForce = 30f, timer = 0f;
    void Start()
    {
        isDown = false;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(isDown && timer > delay)
        {
            Shoot();
            timer = 0f;
        }
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, positionToSpawn.position, positionToSpawn.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(positionToSpawn.up * bulletForce, ForceMode2D.Impulse);
    }

    public void FireButtonDown()
    {
        isDown = true;
    }
    public void FireButtonUp()
    {
        isDown = false;
    }
}
