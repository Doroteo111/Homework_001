using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_5 : MonoBehaviour
{
    public float x = 3.4f;
    public float y = 2f;
    private bool isGreater;

    private void Start()
    {
        Debug.Log(isGreater = x > y);
        
    }

}
