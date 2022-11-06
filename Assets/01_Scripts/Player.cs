using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float x;
    public float y;
    public bool gyroEnabled = true;
    float sensivity = 50f;
    public Transform player;
    public float moveSpeed = 5f;
    Gyroscope gyro;
    public Material material;

    public float distance = 5f;
    float count = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
