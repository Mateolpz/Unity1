using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PilaImagenes : MonoBehaviour
{
    Stack<Sprite> pilaSprites = new Stack<Sprite>();

    public Image contenedorImagen;   // un Image en la UI para mostrar el tope
    public Transform panelPila;      // un Panel donde se clonarán las imágenes
    public GameObject prefabImagen;  // prefab de un UI Image para mostrar la pila
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

         public void PushSprite(Sprite nuevaImagen)
    {
        pilaSprites.Push(nuevaImagen);
        ActualizarPila();
    }

    public void PeekSprite()
    {
        if (pilaSprites.Count > 0)
        {
            Sprite tope = pilaSprites.Peek();
            contenedorImagen.sprite = tope;
            Debug.Log("Peek: " + tope.name);
        }
        else
        {
            Debug.Log("Pila vacía (peek)");
        }
    }

    public void PopSprite()
    {
        if (pilaSprites.Count > 0)
        {
            Sprite eliminado = pilaSprites.Pop();
            Debug.Log("Pop: " + eliminado.name);
            ActualizarPila();
        }
        else
        {
            Debug.Log("Pila vacía (pop)");
        }
    }

    public void ClearStack()
    {
        pilaSprites.Clear();

        foreach (Transform hijo in panelPila)
        {
            Destroy(hijo.gameObject);
        }

        contenedorImagen.sprite = null;
        Debug.Log("Pila de imágenes vaciada");
    }

    void ActualizarPila()
    {
        // Borra las imágenes anteriores
        foreach (Transform hijo in panelPila)
        {
            Destroy(hijo.gameObject);
        }

        // Vuelve a dibujar la pila
        foreach (Sprite s in pilaSprites)
        {
            GameObject go = Instantiate(prefabImagen, panelPila);
            go.GetComponent<Image>().sprite = s;
        }

        // Mostrar el tope
        contenedorImagen.sprite = pilaSprites.Peek();
    }


}

