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
     
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Walk", true);

        rb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(this.transform.position.x - FindObjectOfType<Spawner>().followPoint.position.x,
            this.transform.position.y - FindObjectOfType<Spawner>().followPoint.position.y); 
        rb.AddForce(-direction * speed, ForceMode2D.Impulse);
    }
    void Update()
    {
        if (isDead) Destroy(enemy, 3f);
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.layer == 8) 
        {
            anim.SetBool("Walk", false);
            isDead = true;
            rb.bodyType = RigidbodyType2D.Static;
            enemy.GetComponent<CircleCollider2D>().enabled = false;
        }    
        else if (other.gameObject.layer == 7) Destroy(enemy);
    }
}
