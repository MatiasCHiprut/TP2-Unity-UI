using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string ContraseñaCorrecta;
    public Text IngresoUsuario;
    string ContraseñaUsuario;
    public GameObject cartelitomensaje;
    public Text textomensaje;
    // Start is called before the first frame update
    void Start()
    {
        ContraseñaCorrecta = "12345";
        cartelitomensaje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validaContraseña()
    {
        ContraseñaUsuario = IngresoUsuario.text;
        if (ContraseñaUsuario == ContraseñaCorrecta)
        {
            cartelitomensaje.SetActive(true);
            textomensaje.text = "Bienvenido";
            Debug.Log("Bienvenido.");
        }
        else
        {
            cartelitomensaje.SetActive(true);
            textomensaje.text = "Error, contraseña incorrecta.";
            Debug.Log("Error, contraseña incorrecta.");
        }
    }
}
