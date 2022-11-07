using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EXERCISE_6 : MonoBehaviour
{
    //VARIABLE ENTERA QUE GARDA LOS NUMEROS. en base que numeros agrege a cada variable va dentro de x o y
    //operador de decisiones

    public bool isWeekend;

    public float dayWeek = 1;

    private void Start()
    {
        if (isWeekend == false)
        {
            Debug.Log($"Day {dayWeek} belongs to the weekend");

            }else{

            Debug.Log($"Day {dayWeek}  does not belongs to the weekend");
        }



        

    }




    
}
