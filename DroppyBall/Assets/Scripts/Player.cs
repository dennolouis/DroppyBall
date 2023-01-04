using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int ballIndex; 
    [SerializeField] List<GameObject> balls;   


    int currency = 0;
    
    int lives = 0;
    int score = 0;
    TextMeshProUGUI scoreTMP;



    // Start is called before the first frame update
    void Start()
    {
        scoreTMP = GameObject.FindGameObjectWithTag("ScoreTMP").GetComponent<TextMeshProUGUI>();
        scoreTMP.text = "Score: 0";
        Instantiate(balls[ballIndex], new Vector3(0, 1, 0), Quaternion.identity);
    }

    public void DeductLife()
    {
        lives--;
        if(lives <= 0)
            DisplayGameOver();
    }

    public void AddLife()
    {
        lives++;
    }

    public void AddCurrency(int amount)
    {
        currency += amount;
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

    void DisplayGameOver()
    {
        GameObject.FindObjectOfType<GameOver>().Show();
    }
}
