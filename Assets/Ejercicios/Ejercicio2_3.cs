using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int vidas = 10;
        float exp = 11.0f;

        float producto = vidas * exp;
        float cociente = vidas / exp;
        float resto = vidas% (int)exp;
        int dobleVidas = vidas * 2;
        float tripleExp = exp * 3;

        Debug.Log("Producto de vidas * exp: " + producto);
        Debug.Log("Cociente de vidas / exp: " + cociente);
        Debug.Log("Resto de vidas % exp: " + resto);
        Debug.Log("El doble de vidas : " + dobleVidas);
        Debug.Log("El triple de exp: " + tripleExp);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
