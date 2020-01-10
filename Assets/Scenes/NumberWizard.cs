using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        int guess;
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number, but don't tell me what it is.");
        Debug.Log("The highest posible number is: " + max);
        Debug.Log("The lowest possible number is: " + min);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
