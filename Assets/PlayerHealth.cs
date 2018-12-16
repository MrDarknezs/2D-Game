using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int health = 100;

    public void takendamage(int damage)
    {
        health -= damage;

        if(health == 0)
        {
            Die();
        }
    }

    void Die()
    {
        DestroyObject(gameObject);
    }

}
