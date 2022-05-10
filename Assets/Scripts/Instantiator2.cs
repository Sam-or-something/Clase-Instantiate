using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator2 : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    public Text txtCloneAmount;

    public void CloneObject()
    {
        cloneAmount = int.Parse(txtCloneAmount.text);
        int i = 0;
        while (i < cloneAmount)
        {
            Instantiate(objectToClone);
            i++;
        }
    }
}
