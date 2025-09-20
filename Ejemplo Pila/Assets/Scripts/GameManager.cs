using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public static GameManager Instance;

    private float globalTime;

    private int scoreApple = 0;
    private int scoreBanana = 0;



    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this; 
        DontDestroyOnLoad(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        globalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TotalTime(float timeScene)
    {
        globalTime += timeScene;
    }

    public void TotalApple(int apple)
    {
        scoreApple += apple;
    }

    public void TotalBanana(int banana)
    {
        scoreBanana += banana;
    }

    public float GlobalTime { get => globalTime; set => globalTime = value; }
    public int ScoreApple { get => scoreApple; set => scoreApple = value; }
    public int ScoreBanana { get => scoreBanana; set => scoreBanana = value; }
}
