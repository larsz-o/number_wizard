using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Hello I am the Wiz!!");
        Debug.Log("Think of a number between " + min + " and " + max + ", but don't tell me what your number is.");
        Debug.Log("Do you have your number yet? Press Y for Yes when you are ready.");
        max = max + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("Excellent! Let me start guessing. Is your number " + guess + "?");
            Debug.Log("If it is higher than " + guess + ", press the Up arrow. If it is lower, press the Down arrow. If my guess is correct, press Enter.");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I got it! Your number is " + guess + ". Do you want to play again? Press Space to restart.");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Let's play again!");
                StartGame();
            } 

        }

    }
     void NextGuess()
        {
            guess = (max + min) / 2;
            Debug.Log("Okay, let me try again. Is your number " + guess + "?");
        }
}
