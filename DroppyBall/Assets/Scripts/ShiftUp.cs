using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftUp : MonoBehaviour
{
   [SerializeField] int speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
    }
}
