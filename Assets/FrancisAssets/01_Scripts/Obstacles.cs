using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Vector3 dir = new Vector3(0,0,-1);
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
