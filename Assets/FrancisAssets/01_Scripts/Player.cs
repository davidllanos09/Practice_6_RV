using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 50;
    public Animator anim;
    public Text pointsTxt;
    public Text lifesTxt;
    public int points = 0;
    public int hp = 10;

    // Start is called before the first frame update
    void Start()
    {
        pointsTxt.text = "Puntos " + points.ToString();
        lifesTxt.text = "Vidas " + hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
       /* if (Mathf.Abs(y) > 0.1f)
            anim.SetBool("isWalking", true);
        else
            anim.SetBool("isWalking", false);*/
        anim.SetFloat("speed", Mathf.Abs(y));
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * x * rotationSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("shoot");
        }
    }
}
