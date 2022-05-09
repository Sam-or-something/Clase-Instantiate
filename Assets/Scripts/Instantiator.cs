using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int numero;

    public void CloneObject()
    {
        //clonar objeto
        int contador = numero;
        while (contador > 0)
        {
            Instantiate(objectToClone);
            contador--;
        }

    }
}
