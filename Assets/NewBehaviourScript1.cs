using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = Max(10, 20);
        Debug.Log(Max(100, 200));
        Max(5, 10);
        
    }

    // Update is called once per frame
    public int Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        return num2;
    }
}




