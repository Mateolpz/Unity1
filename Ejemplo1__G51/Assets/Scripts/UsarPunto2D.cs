using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class UsarPunto2D : MonoBehaviour
{
    List<Vector2> listaPuntos = new List<Vector2>();
    // Start is called before the first frame update
    void Start()
    {
        listaPuntos.Add(new Vector2(1.5f, 3.2f));

        listaPuntos.Add(new Vector2(4.0f, -2.1f));

        listaPuntos.Add(new Vector2(0f, 0f));

        listaPuntos.Add(new Vector2(-5f, 6f));
            


        foreach (Vector2 punto in listaPuntos)
        {
            Debug.Log("Punto" + punto);
        }

        Utilidades util = gameObject.AddComponent<Utilidades>();
        util.GuardarPuntosJson(listaPuntos);
    }
}
