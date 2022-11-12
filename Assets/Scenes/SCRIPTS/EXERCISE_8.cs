using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_8 : MonoBehaviour
{
     public string nameMonth1;   //variable to introduce whatever month in the Inspector.
    

    private void Start()
    {
        if (nameMonth1 == "January" || nameMonth1 == "March" || nameMonth1 == "May" || nameMonth1 == "July" || nameMonth1 == "August" || nameMonth1 == "October" || nameMonth1 == "December")
        {
            Debug.Log($" {nameMonth1} has 31 days!");

        }else if(nameMonth1=="April"|| nameMonth1 == "June" || nameMonth1 == "September" || nameMonth1 == "November"){
            Debug.Log($" {nameMonth1} has 30 days!");

       }else{
            Debug.Log($"This February has 28 days!");
}
        
    } 

    //A decision operation, if the mounth insert on the inspector (for example) doesn't have 31days, that's mean
    // that the operation pass to the other condition.
   

}

    
