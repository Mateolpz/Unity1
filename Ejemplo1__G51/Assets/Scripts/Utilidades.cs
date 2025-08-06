using PackagePersona;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using System.IO;
using Package2D;
using UnityEditor.ShaderKeywordFilter;
using System;


public class Utilidades : MonoBehaviour
{
    public void GuardarEstudianteJson(List<Estudiante> listaEstudiante)
    {
        string ruta = Path.Combine(Application.persistentDataPath, "estudiantes.json");
        string json = JsonUtility.ToJson(new EstudianteListWrapper { estudiantes = listaEstudiante }, true);
        File.WriteAllText(ruta, json);
        Debug.Log("Archivo estudiantes guardado en:" + ruta);
    }

    public void GuardarPuntosJson(List<Vector2> listaPuntos)
    {
        string ruta = Path.Combine(Application.persistentDataPath, "puntos2D.json");
        string json = JsonUtility.ToJson(new Puntos2DListWrapper { puntos = listaPuntos }, true);
        File.WriteAllText(ruta, json);
        Debug.Log("Archivo de puntos 2D guarado en:" + ruta);

    }

}
    [System.Serializable]
    public class EstudianteListWrapper
    {

    public List<Estudiante> estudiantes;

    }

    [System.Serializable]
    public class Puntos2DListWrapper
    {

    public List<Vector2> puntos;

    }





