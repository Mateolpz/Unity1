using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColaPersonas : MonoBehaviour
{
    Queue<Persona> cola = new Queue<Persona>();

    public InputField inputNombre;
    public InputField inputMail;
    public InputField inputDireccion;

    public Text textCola;      // Para mostrar la cola completa
    public Text textMensaje;   // Para mostrar el estado o el Peek

    // Enqueue
    public void EnqueuePersona()
    {
        if (!string.IsNullOrEmpty(inputNombre.text) &&
            !string.IsNullOrEmpty(inputMail.text) &&
            !string.IsNullOrEmpty(inputDireccion.text))
        {
            Persona nueva = new Persona(inputNombre.text, inputMail.text, inputDireccion.text);
            cola.Enqueue(nueva);

            Debug.Log("Enqueue: " + nueva.nombre);
            ActualizarCola();
        }
        else
        {
            Debug.Log("Faltan datos para agregar a la cola");
        }
    }

    // Dequeue
    public void DequeuePersona()
    {
        if (cola.Count > 0)
        {
            Persona eliminado = cola.Dequeue();
            Debug.Log("Dequeue: " + eliminado.nombre);
            textMensaje.text = "Salió: " + eliminado.nombre;
            ActualizarCola();
        }
        else
        {
            Debug.Log("Cola vacía");
            textMensaje.text = "Cola vacía";
        }
    }

    // Peek
    public void PeekPersona()
    {
        if (cola.Count > 0)
        {
            Persona primero = cola.Peek();
            Debug.Log("Peek: " + primero.nombre);
            textMensaje.text = "Primero en cola: " + primero.nombre;
        }
        else
        {
            Debug.Log("Cola vacía");
            textMensaje.text = "Cola vacía";
        }
    }

    // Clear
    public void ClearCola()
    {
        cola.Clear();
        Debug.Log("Cola vacía");
        textCola.text = "";
        textMensaje.text = "Cola vacía";
    }

    // Actualizar el Text con toda la cola
    void ActualizarCola()
    {
        textCola.text = "Cola:\n";
        foreach (Persona p in cola)
        {
            textCola.text += p.nombre + " | " + p.mail + " | " + p.direccion + "\n";
        }
    }
}