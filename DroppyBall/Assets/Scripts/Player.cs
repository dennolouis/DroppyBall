using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int lives = 0;
    [SerializeField] int score = 0;
    [SerializeField] int ballIndex;
    [SerializeField] List<GameObject> balls;


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
            print("Game Over, Score: " + score.ToString()); 
    }

    public void AddLife()
    {
        lives++;
    }

    public void AddScore(int x)
    {
        score += x;
    }

    public GameObject getSelectedBall()
    {
        return balls[ballIndex];
    }
}
