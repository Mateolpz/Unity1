using UnityEngine;

public class FinalFlag : MonoBehaviour
{
    public Final panelController;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().enabled = false;
            panelController.ShowPanel();
        }
    }
}
