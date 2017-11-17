using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawning : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
	void Start ()
    {
        Spawning(5);
    }
    public void Spawning(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Instantiate(enemy, new Vector3(0, 10, 0), transform.rotation);
        }
    }
}
