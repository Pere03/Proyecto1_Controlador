using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{

    /*
    private float playerSpeed = 5.25f;
    public string playerName = "Pere";
    [SerializeField] private bool gameOver; 
    */

    /*
    public int x = 5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;
     */
    public bool isRaining = false;
    public bool isCold = false;
    public int playerAge = 35;
    public int x = 5;
    public int y = 2;


    // Start is called before the first frame update
    void Start()
    {   /*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + "+" + y + "=" + (x - y));
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, x / y));
   

        if (isRaining)
        {
            Debug.Log("Lleva paraguas.");
        } else {
            Debug.Log($"No hace falta paraguas.");
        }
        */

        if (isRaining)
        {
            if (isCold)
            {
                Debug.Log("Lleva paraguas y sudadera.");
            }
            else
            {
                Debug.Log("Lleva paraguas.");
            }
        }
        else
        {
            if (isCold)
            {
                Debug.Log($"Lleva sudadera.");
            }
            else
            {
                Debug.Log($"Disfruta del dia.");
            }
        }
   


        if (playerAge >= 18) 
        {
            Debug.Log("Eres mayor de edad");
        } else if (playerAge >= 13) 
        {
            Debug.Log("Eres adolescente");
             } else if (playerAge >= 4)
             {
                  Debug.Log("Eres un niño");
                  }else
              {
                    Debug.Log("Eres un bebe");
              }


        if (x == 2 || y <= 5)
        {
            Debug.Log("Es Verdadero");
        }
        else {
            Debug.Log("Es Falso");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
