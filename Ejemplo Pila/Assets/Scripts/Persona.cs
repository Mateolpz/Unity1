using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Persona
{
    public string nombre;
    public string mail;
    public string direccion;

    public Persona(string nombre, string mail, string direccion)
    {
        this.nombre = nombre;
        this.mail = mail;
        this.direccion = direccion;
    }

    public override string ToString()
    {
        return nombre + " | " + mail + " | " + direccion;
    }
}