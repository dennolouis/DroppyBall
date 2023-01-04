using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{

    [SerializeField] GameObject[] powerUps;
    [SerializeField] GameObject currency;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 4);
    }

    void Spawn()
    {
        int i = Random.Range(0, powerUps.Length);
        float xpos = Random.Range(-2.5f, 2.5f);
        GameObject p = Instantiate(powerUps[i], new Vector3(xpos, -2.5f, 0), Quaternion.identity);
        Destroy(p, 8f);
        Invoke("SpawnCurrency", Random.Range(10f, 20f));
        Invoke("Spawn", 20f);
    }

    void SpawnCurrency()
    {
        float xpos = Random.Range(-2.5f, 2.5f);
        GameObject cur = Instantiate(currency, new Vector3(xpos, -2.5f, 0), Quaternion.identity);
        Destroy(cur, 8f);
    }
}
