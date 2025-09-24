using UnityEngine;
using TMPro; //Usar TextMeshPro
using UnityEngine.UI;
using System.IO; //Guardar el JSON
public class Final : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI appleText;
    public TextMeshProUGUI bananaText;
    public TMP_Text textTime;
    public TextMeshProUGUI totalText;


    public Button saveButton;
    
    void Start()
    {
        panel.SetActive(false);

        saveButton.onClick.AddListener(SaveDataToJSON);
        
    }

    // Se llama cuando el jugador toca la bandera final
    public void ShowPanel()
    {
        panel.SetActive(true);

        int apples = GameManager.Instance.scoreApple;
        int bananas = GameManager.Instance.scoreBanana;
        textTime.text = " " + GameManager.Instance.GlobalTime.ToString("F2") + " s";
        int total = apples + bananas;

        appleText.text = "Manzanas: " + apples;
        bananaText.text = "Bananas: " + bananas;
        totalText.text = "Total: " + total;

        Time.timeScale = 0f; // Pausa el juego
    }

    void SaveDataToJSON()
    {
        PlayerData data = new PlayerData();
        data.apples = GameManager.Instance.scoreApple;
        data.bananas = GameManager.Instance.scoreBanana;
        data.total = data.apples + data.bananas;
        data.time = GameManager.Instance.GlobalTime; // Guarda el tiempo

        string json = JsonUtility.ToJson(data, true);

        // Ruta en StreamingAssets
        string path = Path.Combine(Application.streamingAssetsPath, "playerData.json");
        File.WriteAllText(path, json);

        Debug.Log("Datos guardados en: " + path);
    }

  
}

[System.Serializable]
public class PlayerData
{
    public int apples;
    public int bananas;
    public int total;
    public float time;
}
