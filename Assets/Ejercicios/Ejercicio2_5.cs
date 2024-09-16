using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int vidasPlayer1 = 5;
        int vidasPlayer2 = 10;
        int vidasPlayer3 = 15;
        int vidasPlayer4 = 20;

        Debug.Log("Valores ininciales:");
        Debug.Log("vidasPlayer1: " + vidasPlayer1);
        Debug.Log("vidasPlayer2: " + vidasPlayer2);
        Debug.Log("vidasPlayer3: " + vidasPlayer3);
        Debug.Log("vidasPlayer4: " + vidasPlayer4);


        int temp;

        temp = vidasPlayer2;
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = temp;

        Debug.Log("Valores despues del intercambio");
        Debug.Log("vidasPlayer1 : " + vidasPlayer1);
        Debug.Log("vidasPlayer2 : " + vidasPlayer2);
        Debug.Log("vidasPlayer3 : " + vidasPlayer3);
        Debug.Log("vidasPlayer4 : " + vidasPlayer4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
