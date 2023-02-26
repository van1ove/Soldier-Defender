using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIElements;
public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    public float lifetime = 3f, timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= lifetime)
        {
            Destroy(bullet);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.layer == 6) 
        {
            FindObjectOfType<Score>().GetPoints();
            Destroy(bullet);
        }    
    }
}
