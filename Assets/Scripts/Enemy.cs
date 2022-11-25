using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float speed = 100f; 
    private Animator anim;
    private Rigidbody2D rb;
    private bool isDead = false;
    private float delay;
     
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Walk");

        rb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(this.transform.position.x - FindObjectOfType<Spawner>().followPoint.position.x,
            this.transform.position.y - FindObjectOfType<Spawner>().followPoint.position.y); 
        rb.AddForce(-direction * speed, ForceMode2D.Impulse);
    }
    void Update()
    {
        if (isDead) Destroy(enemy, delay);
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.layer == 8) 
        {
            anim.SetTrigger("Die");
            delay = 3f;
        }    
        else if (other.gameObject.layer == 7) 
        {
            anim.SetTrigger("Explode");
            delay = 1f;
        }
        rb.bodyType = RigidbodyType2D.Static;
        enemy.GetComponent<CircleCollider2D>().enabled = false;
        isDead = true;
    }
}
