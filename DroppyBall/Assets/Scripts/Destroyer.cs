using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    int amount = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnCollisionEnter(Collision other)
    {

        print(other.gameObject.name);
        if(amount <= 0) Destroy(this);

        //if(other.gameObject.GetComponent<Spin>())
        if(other.gameObject.name[0] == 'C')
        {
            Destroy(other.gameObject);
            amount--;
        }
    }
}
