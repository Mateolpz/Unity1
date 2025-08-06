using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class UsarPunto2D : MonoBehaviour
{
    List<Vector2> listarPuntos = new List<Vector2>();
    // Start is called before the first frame update
    void Start()
    {
        listarPuntos.Add(new Vector2(1.5f, 3.2f));

        listarPuntos.Add(new Vector2(4.0f, -2.1f));

        listarPuntos.Add(new Vector2(0f, 0f));

        listarPuntos.Add(new Vector2(-5f, 6f));
            


        foreach (Vector2 punto in listarPuntos)
        {
            Debug.Log("Punto" + punto);
        }


        Utilidades util = gameObject.AddComponent<Utilidades>();
        util.GuardarPuntosJson(listarPuntos);

    }
}
