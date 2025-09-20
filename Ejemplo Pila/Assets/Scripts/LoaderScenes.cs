
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoaderScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoaderScenesM(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

}
