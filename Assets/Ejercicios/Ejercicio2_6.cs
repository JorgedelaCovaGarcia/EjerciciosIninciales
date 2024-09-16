using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int puntuacion1 = 100;
        int puntuacion2 = 150;
        int puntuacion3 = 200;

        Debug.Log("Puntuacion 1: " + puntuacion1);
        Debug.Log("Puntuacion 2: " + puntuacion2);
        Debug.Log("Puntuacion 3: " + puntuacion3);

        double media = (puntuacion1 + puntuacion2 + puntuacion3)/ 3.0;

        Debug.Log("La media de las puntuaciones es: " +  media);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
