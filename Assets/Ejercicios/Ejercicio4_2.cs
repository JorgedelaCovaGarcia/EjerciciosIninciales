using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string resultado = ConstruirNombre("Jorge ", "de la Cova ", "Garcia ", 19);
        Debug.Log(resultado);
    }

    string ConstruirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        string nombreCompleto = "La persona se llama " + nombre + apellido1 + apellido2 + " y tiene " + edad + " años";
        return nombreCompleto;
    }
}
