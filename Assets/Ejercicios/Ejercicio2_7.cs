using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oroPorSegundo = 7;
    int horas = 4;
    int segundosPorHora = 3600;
    // Start is called before the first frame update
    void Start()
    {
        int totalSegundos = horas * segundosPorHora;
        int oroTotal = totalSegundos * oroPorSegundo;
        Debug.Log("El total de oro conseguido es: " + oroTotal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
