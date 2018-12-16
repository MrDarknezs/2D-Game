using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBullet : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject bullet;

    public int damage = 30;

	// Use this for initialization
	void Start () {
        rb.velocity = transform.right * speed;
	}

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth playerHealth = hitInfo.GetComponent<PlayerHealth>();
        Debug.Log("We hit " + hitInfo.name);
        if (hitInfo.tag == "player")
        {
            playerHealth.takendamage(damage);
        }
        DestroyObject(gameObject);
    }
}
