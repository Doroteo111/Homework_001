using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_4 : MonoBehaviour
{
    public float currentYear = 2022f;
    public float birthYear = 2003f;
    private float age;           //private variable, it's key of the operation

    private void Start()
    {
        Debug.Log(age = currentYear - birthYear);      //Arithmetic operation, a subtraction one
        Debug.Log($"If we are in the year {currentYear} and you were born in {birthYear}, " +
            $"you are {age} years old");
    }
}
