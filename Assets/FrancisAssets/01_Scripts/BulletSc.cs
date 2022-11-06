using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSc : MonoBehaviour
{
    public float speed = 7;
    public Vector2 dir = new Vector2(0, 1);
    public Rigidbody rb;
    public float timeToDestroy = 3;
    public bool isPlayerBullet = true;

    void Start()
    {
        Destroy(gameObject, timeToDestroy);
        rb.velocity = dir.normalized * speed;
    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && isPlayerBullet)
        {
            Enemy e = collision.gameObject.GetComponent<Enemy>();
            e.TakeDamage();
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player") && !isPlayerBullet)
        {
            Movement p = collision.gameObject.GetComponent<Movement>();
            p.TakeDamage();
            Destroy(gameObject);
        }
    }
}
