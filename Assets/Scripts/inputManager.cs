using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputManager : MonoBehaviour
{
    public InputField ifUserName;
    public Text txtUserName;

    public void UserGreetings()
    {
        Debug.Log(int.Parse(txtUserName.text) * 2);
    }
}
