using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    int vida1 = 50; int vida2 = 50;
    void Start()
    {
        if(vida1 == vida2)
        {
            Debug.Log("Los oponentes tienen la misma vida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
