using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadKmh;

    // Start is called before the first frame update
    void Start()
    {
        float velocidadMs = velocidadKmh * 1000 / 3600;
        Debug.Log(velocidadKmh + " Km/h es igual a " + velocidadMs + " m/s");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
