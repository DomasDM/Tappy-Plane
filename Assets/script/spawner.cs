using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 3;
    public float lastSpawnTime = 0;

    private void Start()
    {
       Instantiate(pipePrefab);
    }

    // Update is called once per frame
    void Update()
    {
      if(Time.time >=lastSpawnTime + spawnRate)
        {
            var pos = transform.position;
            pos.y += Random.Range(-1f, 4f);
            pos.x += Random.Range(-1f, 2f);

            Instantiate(pipePrefab,pos,Quaternion.identity);
            lastSpawnTime = Time.time;
        }
    }
}
