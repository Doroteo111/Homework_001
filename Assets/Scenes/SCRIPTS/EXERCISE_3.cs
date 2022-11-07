using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_3 : MonoBehaviour
{
    public int personAge = 18;
    public string personName = "Isa";

    private void Start()
    {
        Debug.Log($"Hello, {personName} ! You are {personAge} years old");
    }

}
