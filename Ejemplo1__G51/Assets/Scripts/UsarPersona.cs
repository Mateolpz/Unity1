using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PackagePersona;
using Package2D;
using System.IO;


public class UsarPersona : MonoBehaviour
{
    List<Estudiante> listaE = new List<Estudiante>();
    private List<Vector2> listarEstudiantes;

    // Start is called before the first frame update
    public void Start()
    {
        Estudiante e1 = new Estudiante("2025_1", "Ing Multimedia", "Mateo Lopez", 
            "mateo.lopez_vasquez@uao.edu.co", "crra 1A");

        Estudiante e2 = new Estudiante("2025_2", "Ing Ambiental", "Sofia Lopez",
           "sofia.lopez@uao.edu.co", "crra 3b");

        listaE.Add(e1);
        listaE.Add(e2);

        for (int i = 0; i < listaE.Count; i++)
        {
            Debug.Log(listaE[i].NameP + " " + listaE[i].Carrera);
        }

        Utilidades util = gameObject.AddComponent<Utilidades>();
        util.GuardarEstudianteJson(listaE);
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
     
}
