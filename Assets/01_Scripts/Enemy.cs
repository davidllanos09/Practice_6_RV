using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int hp = 3;
    public Rigidbody rb;


    public void TakeDamage()
    {
        hp--;
        if (hp <= 0)
        {           
            Destroy(gameObject);
        }
    }
}
