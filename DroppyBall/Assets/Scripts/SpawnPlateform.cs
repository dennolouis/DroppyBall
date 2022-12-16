using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlateform : MonoBehaviour
{

    [SerializeField] GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
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
}
