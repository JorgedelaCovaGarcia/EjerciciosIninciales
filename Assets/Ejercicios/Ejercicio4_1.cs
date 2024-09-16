using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultado = AreaTriangulo(3.0f, 4.5f);
        Debug.Log(resultado);

        float resultado2 = AreaCuadrado(4.0f, 4.0f);
        Debug.Log(resultado2);

        float resultado3 = AreaCirculo(5.0f, 3.14f);
        Debug.Log(resultado3);
    }

    float AreaCirculo(float radio, float PI)
    {
        float areaCirculo = radio * radio * PI;
        return areaCirculo;
    }

    float AreaTriangulo(float basee, float altura)
    {
        float areaTriangulo = basee * altura / 2;
        return areaTriangulo;
    }

    float AreaCuadrado(float lado, float lado2)
    {
        float areaCuadrado = lado * lado2;
        return areaCuadrado;
    }


}
