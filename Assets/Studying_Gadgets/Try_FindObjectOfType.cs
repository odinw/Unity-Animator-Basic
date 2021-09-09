using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try_FindObjectOfType : MonoBehaviour
{
    public void Button_FindObjectOfType()
    {
        Debug.Log(nameof(Button_FindObjectOfType));
        FindObjectOfType<Hider>().Say();

        //var hider = FindObjectOfType<Hider>();
        //hider.Say();
    }
    
}
