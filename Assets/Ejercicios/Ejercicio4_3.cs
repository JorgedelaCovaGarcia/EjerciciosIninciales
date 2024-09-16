using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string resultado = ConvertirMonedas(10.0f, "USD ", 0.631f);
        Debug.Log(resultado);
    }

    string ConvertirMonedas(float cantidad, string moneda, float valor)
    {
        string conversor = moneda + cantidad + " = " + cantidad * valor + " EUR";
        return conversor;
    }
}
