using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int num;
    void Start()
    {
        for (int i = -num; i < num; i++)
        {
            Debug.Log(i);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
