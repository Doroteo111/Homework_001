using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EXERCISE_1 : MonoBehaviour
{
    public float x = 3f;   //These variables are public in order to be able to change their value in the Inspector
    public float y = 5f;
    public float z = 7f;
    private float result;   

    private void Start()
    {
        Debug.Log(result = x + y + z);  //The result it only seen in the console

    }

}
