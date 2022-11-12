using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_10 : MonoBehaviour
{
    public int x = 2;    //Arithmetic operation
 
    private void Start()
    {
        Debug.Log($"2 x 1 = {x * 1}");  //We repeat the same pattern to get the multiplication table of 2
        Debug.Log($"2 x 2 = {x * 2}");
        Debug.Log($"2 x 3 = {x * 3}");
        Debug.Log($"2 x 4 = {x * 4}");
        Debug.Log($"2 x 5 = {x * 5}");
        Debug.Log($"2 x 6 = {x * 6}");
        Debug.Log($"2 x 7 = {x * 7}");
        Debug.Log($"2 x 8 = {x * 8}");
        Debug.Log($"2 x 9 = {x * 9}");
        Debug.Log($"2 x 10 = {x * 10}"); 
    }
}
