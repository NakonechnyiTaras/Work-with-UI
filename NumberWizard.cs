using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    void Start()
    {
        StartGame();
    }


   

    void StartGame()
    {

        OnNextGuess();
      
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        OnNextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        OnNextGuess();
    }

    public void OnNextGuess()
    {
       
        guess = Random.Range(min, max );

        if(guess > 1000)
        {
            guess = 1000;
        }

        guessText.text = guess.ToString();

    }

    
}
