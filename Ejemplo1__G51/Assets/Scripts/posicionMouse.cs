using Package2D;
using PackagePersona;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOverPanel : MonoBehaviour
{
    public RectTransform panelNaranja; // Asigna aquí tu panel rojo (RectTransform)
    List<Puntos2D> puntos = new List<Puntos2D>();

    public void Start()
    {

    }

    void Update()
    {
        Vector2 localMousePos;

        // Verifica si el mouse está sobre el panel
        if (RectTransformUtility.RectangleContainsScreenPoint(panelNaranja, Input.mousePosition))
        {
            // Convierte a coordenadas locales del panel
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                panelNaranja,
                Input.mousePosition,
                null, // o Camera.main si el Canvas está en Screen Space - Camera
                out localMousePos
            );

            Puntos2D punto2D = new Puntos2D(localMousePos.x, localMousePos.y);
            puntos.Add(punto2D);



            //Debug.Log(" Mouse sobre panel naranja. Pos local: " + localMousePos.x);
            //Debug.Log(" Mouse sobre panel naranja. Pos local: " + localMousePos);
        }


    }
    public void saveDataPuntos()
    {
        Utilidades.SaveDataPuntos(puntos);
    }



}

