using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        int doble = numero * 2;
        int triple = numero * 3;
        Debug.Log(numero + " multiplicado por 2: " + doble);
        Debug.Log(numero + " multiplicado por 3: " + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
