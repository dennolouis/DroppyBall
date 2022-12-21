using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int ballIndex; 
    [SerializeField] List<GameObject> balls;   
    
    int lives = 0;
    int score = 0;
    TextMeshProUGUI scoreTMP;



    // Start is called before the first frame update
    void Start()
    {
        scoreTMP = GameObject.FindGameObjectWithTag("ScoreTMP").GetComponent<TextMeshProUGUI>();
        scoreTMP.text = "Score: 0";
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
        scoreTMP.text = "Score: " + score.ToString();
    }

    public GameObject getSelectedBall()
    {
        return balls[ballIndex];
    }
}
