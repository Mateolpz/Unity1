using System.Collections.Generic;
using UnityEngine;

public class MouseOverPanel : MonoBehaviour
{
    public RectTransform PanelPuntos2D;
    public UsarPunto2D UsarPunto2D;
    public Utilidades utilidades;
    private List<Vector2> listaPuntos = new List<Vector2>();
    private Vector2 ultimaCoordenada;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Solo cuando haces clic izquierdo
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(PanelPuntos2D, Input.mousePosition))
            {
                Vector2 localMousePos;
                RectTransformUtility.ScreenPointToLocalPointInRectangle(
                    PanelPuntos2D,
                    Input.mousePosition,
                    null, // o Camera.main si tu Canvas está en Screen Space - Camera
                    out localMousePos
                );


                UsarPunto2D.ultimaCoordenada = localMousePos;


                Debug.Log("Clic dentro del panel naranja. Pos local: " + localMousePos);
            }
        }
    }
    public void AddPuntoList()
    {

        listaPuntos.Add(ultimaCoordenada);
        Utilidades.GuardarPuntosJson(listaPuntos);


    }
}

