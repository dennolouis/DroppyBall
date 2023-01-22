using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    //this will not be serialized (public to the inspector). instead there will be a screen where the user can select a ball in game
    [SerializeField] int ballIndex; 
    [SerializeField] List<GameObject> balls;   


    int currency = 0;
    
    int lives = 0;
    int score = 0;

    TextMeshProUGUI scoreTMP;
    TextMeshProUGUI currencyTMP;



    // Start is called before the first frame update
    void Start()
    {
        scoreTMP = GameObject.FindGameObjectWithTag("ScoreTMP").GetComponent<TextMeshProUGUI>();
        scoreTMP.text = "Score: 0";

        currencyTMP = GameObject.FindGameObjectWithTag("CurrencyTMP").GetComponent<TextMeshProUGUI>();
        currencyTMP.text = "$ -";
        
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
        currencyTMP.text = "$ " + currency.ToString();
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
