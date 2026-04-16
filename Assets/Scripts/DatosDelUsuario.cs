using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
     public string nombre = "Santino";
     public int edad = 16;
     public float estatura = 1.85f;
     public bool esONoDonante = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombre + ",tengo " + edad + ",mido " + estatura + ",y es " + esONoDonante + " que done organos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
