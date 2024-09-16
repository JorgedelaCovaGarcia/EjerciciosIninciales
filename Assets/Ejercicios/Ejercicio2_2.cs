using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int vidas = 3;
        float exp = 2.5f;
        char carac = 'A';

        Debug.Log("Vidas : " + vidas);
        Debug.Log("Exp : " + exp);

        float resultadoSuma = vidas + exp;
        float resultadoResta = exp - vidas;

        Debug.Log("Resultado de la suma :" + resultadoSuma);
        Debug.Log("Resultado de la resta :" + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
