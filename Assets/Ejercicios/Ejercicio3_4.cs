using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] float EXP;
    // Start is called before the first frame update
    void Start()
    {
        float lvl = 32 + (9 * EXP / 5);
        Debug.Log("Nivel de personaje: " + lvl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
