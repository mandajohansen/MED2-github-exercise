using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExerciseCode : MonoBehaviour
{
    int myVariable = 0;

    private void Start() {
        Debug.Log("value before calling function: " + myVariable);

        // Call the function 'PassByValue' below this line – pass 'myVariable' as argument.
        PassByReference(ref myVariable);
        // Forklaring :))
        
        Debug.Log("value after calling function: " + myVariable);
    }
//hej med dig
    public void PassByValue(int var)
    {
        var = var + 10;
        Debug.Log("Value inside function: " + var);
    }

    public void PassByReference(ref int var)
    {
        var = var + 20;
        Debug.Log("Value inside function: " + var);
    }
}