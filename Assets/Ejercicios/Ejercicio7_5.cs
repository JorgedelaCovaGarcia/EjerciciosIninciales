using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int contador;
    // Start is called before the first frame update
    void Start()
    {
        while (contador > 0)
        {
            Debug.Log("Muestra el numero: " + contador);
            contador--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
