using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PackagePersona;
using Package2D;
using System.IO;
using TMPro;

public class UsarPersona : MonoBehaviour
{
    List<Estudiante> listaE = new List<Estudiante>();
    private List<Vector2> listarEstudiantes;

    public TMP_InputField codeStudent;
    public TMP_InputField carreraStudent;
    public TMP_InputField nameStudent;
    public TMP_InputField mailStudent;
    public TMP_InputField dirStudent;
    
    

    // Start is called before the first frame update
    public void Start()
    {
        //Estudiante e1 = new Estudiante("2025_1", "Ing Multimedia", "Mateo Lopez", 
        //    "mateo.lopez_vasquez@uao.edu.co", "crra 1A");

        //Estudiante e2 = new Estudiante("2025_2", "Ing Ambiental", "Sofia Lopez",
        //   "sofia.lopez@uao.edu.co", "crra 3b");

        //listaE.Add(e1);
        //listaE.Add(e2);

        //for (int i = 0; i < listaE.Count; i++)
        //{
        //    Debug.Log(listaE[i].NameP + " " + listaE[i].Carrera);
        //}

        //Utilidades util = gameObject.AddComponent<Utilidades>();
        //util.GuardarEstudianteJson(listaE); // Correcto
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void AddStudentList()
    {
        string codeStudent1 = codeStudent.text;
        string carreraStudent1 = carreraStudent.text;
        string nameStudent1 = nameStudent.text;
        string mailStudent1 = mailStudent.text;
        string dirStudent1 = dirStudent.text;
        
        
        Estudiante e1 = new Estudiante(codeStudent1, carreraStudent1, 
            nameStudent1, mailStudent1, dirStudent1);

        listaE.Add(e1);
    }
    public void ShowStudentList()
    {
        foreach (Estudiante e in listaE)
        {
            Debug.Log(e.NameP + " " + e.Codigo + " " + e.Carrera);
        }

        Utilidades.GuardarEstudianteJson(listaE); // Correcto
    }
}
