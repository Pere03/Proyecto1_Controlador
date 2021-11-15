using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour
{
    public Vector3 myPos;
    public string hello;

    public int Numero1;
    public int Numero2;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(Multiplicacion(Numero1, Numero2));

        /*
        HelloWorld();

        hello = GetHello();
        Debug.Log(hello);
        */

        /*
        myPos = new Vector3(1,5,0);
        transform.position = myPos;
        Debug.Log(transform.position);
        */

        /*
        myPos = Vector3.up;
        transform.position = myPos; 
        Debug.Log(transform.position);
        */


    }

    // Update is called once per frame
    void Update()
    {

        MovementToDirection(KeyCode.D, Vector3.right);

        MovementToDirection(KeyCode.A, Vector3.left);

        MovementToDirection(KeyCode.W, Vector3.forward);

        MovementToDirection(KeyCode.S, Vector3.back);

        MovementToDirection(KeyCode.Q, Vector3.up);

        MovementToDirection(KeyCode.E, Vector3.down);

        //Movimiento direccion con funcion

        MovementToRotate(KeyCode.RightArrow, new Vector3(0, 10, 0));

        MovementToRotate(KeyCode.LeftArrow, new Vector3(0, -10, 0));

        MovementToRotate(KeyCode.UpArrow, new Vector3(10, 0, 0));

        MovementToRotate(KeyCode.DownArrow, new Vector3(-10, 0, 0));

        ////Movimiento rotacion con funcion

        MovementToScale(KeyCode.R, Vector3.right);

        MovementToScale(KeyCode.Y, Vector3.up);

        MovementToScale(KeyCode.Backspace, Vector3.forward);
        //Movimiento escala con funcion
    }
    /*
    public void HelloWorld()
    {
    Debug.Log("¡Hola Mundo!");
    }

    public string GetHello()
    {
        return "¡Hola!";
    }

    */

    public void MovementToDirection(KeyCode key, Vector3 direccion)
    {
        if (Input.GetKeyDown(key))
        {
            transform.position += direccion;
        }
    }

    public void MovementToScale(KeyCode key, Vector3 escala)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += escala;
        }
    }

    public void MovementToRotate(KeyCode key, Vector3 Rotacion)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(Rotacion);
        }
    }

    public int Multiplicacion(int numero1, int numero2)
    {
        int resultado = numero1 * numero2;
        Debug.Log($"{Numero1} * {Numero2} = {resultado}");
        return resultado;
    }
}
