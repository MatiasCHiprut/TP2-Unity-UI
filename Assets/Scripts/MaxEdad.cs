using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxEdad : MonoBehaviour
{
    public int edad;
    public Text Text1;
    // Start is called before the first frame update
    void Start()
    {
        if (edad >= 18)
        {
            Text1.text=("Eres mayor de edad.");
            Debug.Log("Eres mayor de edad.");
        }
        else
        {
            Debug.Log("No eres mayor de edad.");
            Text1.text = ("Eres mayor de edad.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
