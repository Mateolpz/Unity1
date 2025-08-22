using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PilaTexto : MonoBehaviour
{
    Stack<string> pilaNombres = new Stack<string>();

    public TMP_InputField inputNombre;   
    public TMP_Text textPila;            
    public TMP_Text textMensajes;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushString()
    {
        if (!string.IsNullOrEmpty(inputNombre.text))
        {
            string nombre = inputNombre.text;
            pilaNombres.Push(nombre);
            ActualizarPila(); // Actualizar la visualización de la pila

            textMensajes.text = "Push: '" + nombre + "'";
            

            inputNombre.text = ""; // limpiar input
        }
        else
        {
            textMensajes.text = "El input está vacío";
        }
    }

    public void PeekString()
    {
        if (pilaNombres.Count > 0)
        { 
            string tope = pilaNombres.Peek();
        Debug.Log("Tope actual: " + pilaNombres.Peek());
        textMensajes.text = "Peek: '" + tope + "'";

        }

        else
        {
            Debug.Log("Pila vacía, no hay tope");
            textMensajes.text = "Peek: pila vacía";
        }
    }

    public void PopString()
    {
        if (pilaNombres.Count > 0)
        {
            string eliminado = pilaNombres.Pop();
            Debug.Log("Se eliminó: " + eliminado);
            textMensajes.text = "Pop: '" + eliminado + "'";
            ActualizarPila();
        }
        else
        {
            Debug.Log("Pila vacía, no se puede eliminar ");
            textMensajes.text = "Pop: pila vacía";
        }


    }

    public void ClearStack()
    {
        pilaNombres.Clear();
        Debug.Log("Pila vacía ");
        textMensajes.text = "Clear: pila vacía";
        textPila.text = "PILA (tope  fondo)\n";
        ActualizarPila();
    }


    void ActualizarPila()
    {
        string contenido = "PILA (tope  fondo)\n";
        foreach (string nombre in pilaNombres)
        {
            contenido += "- " + nombre + "\n";
        }
        textPila.text = contenido;
    }
}
