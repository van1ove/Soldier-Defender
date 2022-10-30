using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    private Animator anim;
    private bool isDead = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (isDead) Destroy(enemy, 3f);
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.layer == 8) 
        {
            anim.SetTrigger("Die");
            isDead = true;
        }    
    }
}
