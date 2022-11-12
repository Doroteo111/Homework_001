using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_9 : MonoBehaviour
{

    public int amountCandy = 16; //in Module operation we always use 'int'
    public int amountPeople = 4;
    private float result;
    private int result2;

    private void Start()
    {
        result = amountCandy / amountPeople;
        Debug.Log($"Everybody have {result} candies.");

        result2 = amountCandy % amountPeople;      //I used 'module' to calculate the rest of the operation, we only want that value
        Debug.Log($"There's {result2} candies left over.");

    }

}
