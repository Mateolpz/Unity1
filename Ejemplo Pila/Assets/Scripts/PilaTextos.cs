using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PilaTexto : MonoBehaviour
{
    Stack<string> pilaNombres = new Stack<string>();

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushString()
    {
       
    }

    public void PeekString()
    {
      
        Debug.Log("Tope actual: " + pilaNombres.Peek());
            
      
       
    }

    public void PopString()
    {
        if (pilaNombres.Count > 0)
        {
          
            Debug.Log("Se eliminó: " + pilaNombres.Pop()); ;
            
        }
        else
        {
            Debug.Log("Pila vacía, no se puede eliminar ");
            
        }

       
    }

    public void ClearStack()
    {
        pilaNombres.Clear();
        Debug.Log("Pila vacía ");
    }
}
