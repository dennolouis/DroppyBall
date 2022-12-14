using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int lives = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeductLife()
    {
        lives--;
        if(lives <= 0)
            print("Game Over"); 
    }

    public void AddLife()
    {
        lives++;
    }
}
