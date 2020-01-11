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
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number, but don't tell me what it is.");
        Debug.Log("The highest posible number is: " + max);
        Debug.Log("The lowest possible number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than my guess.");
        Debug.Log("Push up = Higher,  Push down = Lower, Push Enter for correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess; 
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }




    }
}
