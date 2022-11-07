using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public AudioClip destroyedSoundEffect;
    public float speed = 0.01f;
    public GameObject destroyedEffect;

    void Start()
    {
        speed = Random.Range(0.01f, 0.5f);
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    public void Destroyer()
    {
        AudioManager.instance.PlaySFX(destroyedSoundEffect);
        Instantiate(destroyedEffect, transform.position,
            destroyedEffect.transform.rotation);
        Destroy(gameObject);
    }
}
