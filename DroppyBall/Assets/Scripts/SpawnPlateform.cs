using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlateform : MonoBehaviour
{

    [SerializeField] GameObject platform;
    [SerializeField] GameObject verticlePlatform;
    [SerializeField] GameObject bucketPlatform;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        Invoke("SpawnVerticle", 50);
        Invoke("SpawnBucket", 80);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        float xpos = Random.Range(-2.5f, 2.5f);
        GameObject plat = Instantiate(platform, new Vector3(xpos, -5f, 0), Quaternion.identity);
        Destroy(plat, 4.5f);
        Invoke("Spawn", 0.5f);
    }

    void SpawnVerticle()
    {
        int n = Random.Range(1, 3);
        for(int i = 0; i < n; i++)
        {
            float xpos = Random.Range(-2.5f, 2.5f);
            GameObject vplat = Instantiate(verticlePlatform, new Vector3(xpos, -5f, 0), Quaternion.identity);
            Destroy(vplat, 20f);
        }
        
        Invoke("SpawnVerticle", Random.Range(20f, 40f));
    }

    void SpawnBucket()
    {
        float xpos = Random.Range(-2.5f, 2.5f);
        GameObject bplat = Instantiate(bucketPlatform, new Vector3(xpos, -5f, 0), Quaternion.identity);
        Destroy(bplat, 4.5f);
        Invoke("SpawnBucket", Random.Range(40f, 60f));
    }
}
