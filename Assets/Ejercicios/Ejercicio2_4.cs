using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int vidas = 3;

        Debug.Log("Valor inicial de vidas: " + vidas);

        vidas += 50;
        Debug.Log("Despues de incrementar en 50, vidas: " + vidas);

        vidas -= 2;
        Debug.Log("Despues de decrementar en 2, vidas: " + vidas);

        vidas *= 3;
        Debug.Log("Despues de triplicar, vidas: " + vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
