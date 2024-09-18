using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    int vida1 = 0; int vida2 = 2;
    void Start()
    {
        if ( vida1 < 3 && vida2 < 3)
        {
            Debug.Log("Vida1 y Vida2 son menores que 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
