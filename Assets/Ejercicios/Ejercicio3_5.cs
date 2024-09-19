using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float PI = 3.14f;

    
    void Start()
    {
        float circuferencia = 2 * PI * radio;
        float areaDeLaCircuferencia = PI * radio * radio;
        Debug.Log("La circuferencia es: " +  circuferencia);
        Debug.Log("El area de la circuferencia es: " +  areaDeLaCircuferencia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
