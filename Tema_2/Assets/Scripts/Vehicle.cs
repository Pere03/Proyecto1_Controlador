using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    public string playerName = "Pere";
    [SerializeField] private bool gameOver;
    [SerializeField] private string sound = "¡Brum, brum!";

    [SerializeField] private string Name = "";
    [SerializeField] private int numberWheels = 4;
    //La variable Name no contiene ningun valor, y la variable numberWheels contiene valor 4

    [SerializeField] private bool hasSiren;
    // La variable hasSiren es una variable boleana, asi que por defecto no tiene nada asignado, osea que esta en false.

    [SerializeField] private bool isOn;

    [SerializeField] private float Gasolina = 0f;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log($"{Name} tiene {numberWheels} ruedas y hace {sound}");
        //Mensaje coche y ambulancia

        if (hasSiren)
        {
            Debug.Log($"{Name} tiene sirena");
        }
        else
        {
            Debug.Log($"{Name} no tiene sirena");
        }

    }
    //Mensaje sirena
   */
        if (isOn == true)
        {
            Debug.Log("sound");
        } else if (hasSiren == true) {
            Debug.Log($"{Name} hara {sound} cuando se ponga en marcha.");
        } else {
            Debug.Log($"{Name} no esta en marcha.");
        }
        //Indica un mensaje dependiendo de si esta encendido o no.


        if (Gasolina < 10 && isOn == true)
        {
            Debug.Log($"¡A {Name} le queda poca gasolina!");
        }
        else if (hasSiren == true)
        {
            Debug.Log($"{sound}");
            } 
            else if (hasSiren == false)
            {
                Debug.Log($"{Name} no tiene sirena");
                } 
                else if (isOn == false)
                {
                Debug.Log($"{Name} no esta en marcha");
                }

            


    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == true && Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.back;
        }
    }
}
    