using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cainos.PixelArtTopDown_Basic;
public class Excepciones : MonoBehaviour
{
    public GameObject Glow;
    int divide(int a, int b)
    { 
    if (a == 0)
        {
            throw new DivideByZeroException("No se puede dividir por 0.");
        }
    return a / b;
    }

    int GetArrayValue(int [] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Indice fuera de rango. Checate");
        }
            return array[index];
    }

    int CastStringToInt(string _str)
    {
        return int.Parse(_str);
    }

    void Start()
    {
        try
        {
            int result = divide(10, 0);
            Debug.Log("Resultado de la division: " + result);
        }
        catch (DivideByZeroException exception)
        {
            Debug.Log("Error: division por cero: " + exception.Message);
        }

        try
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int val = GetArrayValue(array, 7);
            Debug.Log("Valor Obtenido: " + val);
        }
        catch (IndexOutOfRangeException ex2)
        {
            Debug.LogError("Error: Indice fuera de rango. Detalles: " + ex2.Message);
        }

        try
        {
            string str = "345h";
            //int result = CastStringToInt(....);
            int result = CastStringToInt(str);
            Debug.Log("Numero convertido: " + result);
        }
        catch (FormatException ex3)
        {
            Debug.LogError("Error: Formato incorrecto. Detalles: " + ex3.Message);
        }
        catch (Exception ex4)
        {
            Debug.LogError("Error general. Detalles: " + ex4.Message);
        }
    }






    private void OnTriggerEnter2D(Collider2D Collision)
    {

        if (Collision.CompareTag("Player"))
            try
            {

                if (Collision.GetComponent<TopDownCharacterController>().id == 1)
                {
                    transform.parent.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    throw new Exception("te falta nivel ");
                            }
            }
            catch (Exception ex)
            {
                Debug.Log("Game: " + ex.Message);
            }
    }
    private void OnTriggerExit2D(Collider2D Collision)
    {

        if (Collision.CompareTag("Player"))
        {
            transform.parent.GetChild(0).gameObject.SetActive(true);
        }

    }

    void Update()
    {
        
    }
}
