using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    private Score Score;
    private Enemy_Spawning Enemy_Spawning;
    private int health = 100;

    private void Start()
    {
        Score = GameObject.Find("Game").GetComponent<Score>();
        Enemy_Spawning = GameObject.Find("Game").GetComponent<Enemy_Spawning>();
    }
    public void TakeDamage(int dmg)
    {
        if (health <= dmg)
        {
            print("des");
            Score.SetScore(health);
            Enemy_Spawning.Spawning(1);
            Destroy(this.gameObject);
        }
        else
        {
            health -= dmg;
            Score.SetScore(dmg);
        }        
    }
}
