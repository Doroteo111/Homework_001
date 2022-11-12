using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_2 : MonoBehaviour
{
    public string name = "Isa";       //Put 2 different variables
    public string city = "Palma";

    private void Start()
    {
        Debug.Log($"Hello, {name} ! Welcome to {city} ");   //Adding them into the sentence
    }
}
