using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{

    [SerializeField] GameObject[] powerUps;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        int i = Random.Range(0, powerUps.Length);
        float xpos = Random.Range(-2.5f, 2.5f);
        GameObject p = Instantiate(powerUps[i], new Vector3(xpos, -2.5f, 0), Quaternion.identity);
        Destroy(p, 8f);
        Invoke("Spawn", 20f);
    }
}
