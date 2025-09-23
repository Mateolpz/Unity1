using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControllerScene2 : MonoBehaviour
{

    public Timer tiempoEscena;
    public TMP_Text textApple;
    public TMP_Text textBanana;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.Instance != null)
        {
          int apples = GameManager.Instance.ScoreApple;
          int bananas = GameManager.Instance.ScoreBanana;

          textApple.text = apples.ToString();
          textBanana.text = bananas.ToString();
        }
        
    }
    public void AddTime()
    {
        tiempoEscena.TimerStop();
        float getTimeScene = tiempoEscena.StopTime;

        GameManager.Instance.TotalTime(getTimeScene);

        Debug.Log("Tiempo Escena 2: " + GameManager.Instance.GlobalTime);
    }
}
