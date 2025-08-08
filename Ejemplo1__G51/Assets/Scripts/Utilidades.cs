using Package2D;
using PackagePersona;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Purchasing.MiniJSON;


public class Utilidades : MonoBehaviour
{
    public static bool GuardarEstudianteJson(List<Estudiante> listaEstudiante)
    {
        bool resultado= false;
        string ruta = Path.Combine(Application.streamingAssetsPath, "estudiantes.json");
        string JsonString = JsonUtility.ToJson(new EstudianteListWrapper { estudiantes = listaEstudiante }, true);
        File.WriteAllText(ruta, JsonString);
        Debug.Log("Lista:" + JsonString);
        return resultado;
    }

    public static bool GuardarPuntosJson(List<Vector2> listaPuntos)
    {
        bool resultado= false;
        string ruta = Path.Combine(Application.streamingAssetsPath, "puntos2D.json");
        string JsonString = JsonUtility.ToJson(new Puntos2DListWrapper { puntos = listaPuntos }, true);
        File.WriteAllText(ruta, JsonString);
        Debug.Log("Lista Puntos:" + JsonString);
        return resultado;

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





