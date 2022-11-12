using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EXERCISE_6 : MonoBehaviour
{

    //Integer variable which keeps the numbers, and it's an a decision operataion

    /*public bool isWeekend; */

    public int dayWeek = 1;
    

    private void Start()
    {
        if (dayWeek >= 6 )
        {
            Debug.Log($"Day {dayWeek} belongs to the weekend");

            }else{

            Debug.Log($"Day {dayWeek}  does not belongs to the weekend");
        }


    }

 
}
