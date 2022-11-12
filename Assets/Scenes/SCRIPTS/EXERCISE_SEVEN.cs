using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_SEVEN : MonoBehaviour
{
    public string letter;

    private void Start()    //it's an a decision operataion
    {
        if (letter=="a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
             Debug.Log($"The letter {letter} is a vowel.");


          }else{     //In case the letter it doesn't be a vowel, the 'if' detect is false, and the 'else' is executed

           Debug.Log($"The letter {letter} is a consonant.");

            
        }
       
    }

}
