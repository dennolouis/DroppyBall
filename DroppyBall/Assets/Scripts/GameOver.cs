using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField] GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(false);
    }

    public void Show()
    {
        screen.SetActive(true);
    }
}
