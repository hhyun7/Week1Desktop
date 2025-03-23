using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Calculator calculator = new Calculator();
        int sum = calculator.Add(3, 5);
        Debug.Log($"3 + 5 = {sum}");

        calculator.Multiple(4, 6);
    }
}

public class Calculator
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} * {num2} = {result}");
    }
}




