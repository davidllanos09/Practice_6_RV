using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSc : MonoBehaviour
{
    public float speed = 7;
    public Vector3 dir = new Vector3(0, 1);
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
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && isPlayerBullet)
        {           
            Enemy e = collision.gameObject.GetComponent<Enemy>();
            e.TakeDamage();
            Movement m = collision.gameObject.GetComponent<Movement>();
            m.AddPoints();
            Destroy item = collision.gameObject.GetComponent<Destroy>();
            item.Destroyer();
            Destroy(gameObject);           
        }
    }
}
