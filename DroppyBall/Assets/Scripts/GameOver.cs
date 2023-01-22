using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField] GameObject screen;

    //at the start of the game make sure the game overscreen is not shown
    void Start()
    {
        screen.SetActive(false);
    }

    public void Show()
    {
        screen.SetActive(true);
    }
}
