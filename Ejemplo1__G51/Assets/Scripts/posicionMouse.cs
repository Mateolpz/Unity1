using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posicionMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 mousePos = Input.mousePosition;
        Debug.Log("Mouse en pantalla: " + mousePos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
