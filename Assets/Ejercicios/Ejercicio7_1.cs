using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    [SerializeField] int contador = 100;
    void Start()
    {
        while (contador > 0)
        {
            Debug.Log("Muestra el numero: " + contador);
            contador --;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
