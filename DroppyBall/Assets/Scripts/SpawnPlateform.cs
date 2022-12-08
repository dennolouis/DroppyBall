using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlateform : MonoBehaviour
{

    [SerializeField] GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        // Spawn(3);
        // GameObject plat = Instantiate(platform, new Vector3(0, -1.5f, 0), Quaternion.identity);
        // Destroy(plat, 3);
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // IEnumerator Spawn(float seconds)
    // {
    //     yield return new WaitForSeconds(seconds);
    //     GameObject plat = Instantiate(platform, new Vector3(0, -1.5f, 0), Quaternion.identity);
    //     Destroy(plat, 3);
    //     StartCoroutine(Spawn(seconds));
    // }

    void Spawn()
    {
        GameObject plat = Instantiate(platform, new Vector3(0, -5f, 0), Quaternion.identity);
        Destroy(plat, 3);
        Invoke("Spawn", 2);
    }
}
