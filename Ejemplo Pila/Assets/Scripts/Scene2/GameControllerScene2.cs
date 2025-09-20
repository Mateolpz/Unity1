using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScene2 : MonoBehaviour
{

    public Timer tiempoEscena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddTime()
    {
        tiempoEscena.TimerStop();
        float getTimeScene = tiempoEscena.StopTime;

        GameManager.Instance.TotalTime(getTimeScene);

        Debug.Log("Tiempo Escena 1: " + GameManager.Instance.GlobalTime);
    }
}
