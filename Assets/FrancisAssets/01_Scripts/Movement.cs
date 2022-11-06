using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 7;
    public float jumpForce = 5;
    NewControls inputs;
    Vector2 dir = Vector2.zero;
    public Text pointsTxt;
    public Text lifesTxt;
    public int points = 0;
    public int hp = 10;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public bool canShoot = true;
    public float timer = 0;
    public float timeBtwShoot = 0.5f;


    void Awake()
    {
        inputs = new NewControls();
        inputs.Player.Movement.performed += ctx => dir = ctx.ReadValue<Vector2>();
        inputs.Player.Movement.canceled += ctx => dir = Vector2.zero;
        inputs.Player.Shoot.performed += ctx => Shoot();
        //inputs.Player.Jump.performed += ctx => Jump();
    }
    void OnEnable()
    {
        inputs.Enable();
    }
    void OnDisable()
    {
        inputs.Disable();
    }
    void Start()
    {
        pointsTxt.text = "Puntos: " + points.ToString();
        lifesTxt.text = "Vidas: " + hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(dir.x * speed, rb.velocity.y, dir.y * speed);
    }
    void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
        }
    }
    void CheckIfCanShoot()
    {
        if (!canShoot)
        {
            timer += Time.deltaTime;
            if (timer > timeBtwShoot)
            {
                canShoot = true;
                timer = 0;
            }
        }
    }
    public void TakeDamage()
    {
        hp--;
        if (hp < 0)
        {
            SceneManager.LoadScene("Game");
            //Destroy(gameObject);
        }
    }
    /* void Jump()
     {
         rb.AddForce(new Vector3(0, 1, 0) * jumpForce, ForceMode.Impulse);
     }*/
}
