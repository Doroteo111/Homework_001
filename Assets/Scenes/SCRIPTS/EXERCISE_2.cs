using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_2 : MonoBehaviour
{
    public string name = "Isa";
    public string city = "Palma";

    private void Start()
    {
        Debug.Log($"Hello, {name} ! Welcome to {city} ");
    }
}
