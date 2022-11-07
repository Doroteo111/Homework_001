using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EXERCISE_1 : MonoBehaviour
{
    public float x = 3f;
    public float y = 5f;
    public float z = 7f;
    [SerializeField] private float result;

    private void Start()
    {
        Debug.Log(result = x + y + z);

    }

}
