using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> obstacles = new List<GameObject>();
    public List<Transform> positions = new List<Transform>();
    public float timer = 0;
    public float timeBtwSpawn = 5;
    // Start is called before the first frame update
    void Start()
    {
       // timeBtwSpawn = Random.Range(2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < timeBtwSpawn)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            int obstacle = Random.Range(0, obstacles.Count);
            int pos = Random.Range(0, positions.Count);
            Instantiate(obstacles[obstacle],
                new Vector3(positions[pos].position.x, transform.position.y, 
                transform.position.z), transform.rotation);
        }
    }
}
