using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
     public int num1 = 9;
     public int num2 = 3;

    // Start is called before the first frame update
    void Start()
    {
         float suma = num1 + num2;
        float resta = num1 - num2;
        float multiplicacion = num1 * num2;
       
        float division = (num2 != 0) ? (num1 / num2) : 0;


        Debug.Log("El resultado de la suma entre " + num1 + " y " + num2 + " es: " + suma);
        Debug.Log("El resultado de la resta entre " + num1 + " y " + num2 + " es: " + resta);
        Debug.Log("El resultado de la multiplicacion entre " + num1 + " y " + num2 + " es: " + multiplicacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

