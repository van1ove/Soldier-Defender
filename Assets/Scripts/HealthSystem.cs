using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] Image healthImage;
    [SerializeField] float damage;
    private float health = 100f;

    void Start()
    {
        healthImage.fillAmount = 1f;
        healthImage.color = Color.green;
    }
    public void GetDamage()
    {
        health -= damage;
    }
    public void SetColor()
    {
        healthImage.fillAmount = health / 100;
        if(health >= 75 && health <= 100)
        {
            healthImage.color = Color.green;
        }
        else if (health >= 25 && health < 75)
        {
            healthImage.color = Color.yellow;
        }
        else if (health > 0 && health < 25)
        {
            healthImage.color = Color.red;
        }
        else 
        {
            Time.timeScale = 0f;
        }
    }
}
