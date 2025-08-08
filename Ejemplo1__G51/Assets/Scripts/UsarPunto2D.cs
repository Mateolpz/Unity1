using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using TMPro;

public class UsarPunto2D : MonoBehaviour
{

    List<Vector2> listaPuntos = new List<Vector2>();
    private List<Vector2> listarPuntos;

    public TMP_InputField xPunto;
    public TMP_InputField yPunto;
    internal static Vector2 ultimaCoordenada;

    // Start is called before the first frame update
    void Start()
    {
        //listaPuntos.Add(new Vector2(1.5f, 3.2f));

        //listaPuntos.Add(new Vector2(4.0f, -2.1f));

        //listaPuntos.Add(new Vector2(0f, 0f));

        //listaPuntos.Add(new Vector2(-5f, 6f));
            


        //foreach (Vector2 punto in listaPuntos)
        //{
        //    Debug.Log("Punto" + punto);
        //}

    }

    public void Update()
    {
        
    }

    
    
}
