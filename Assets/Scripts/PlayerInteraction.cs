using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInterObj = null;

    private void Update()
    {
        if (Input.GetButtonDown("Interact") && currentInterObj)
        {
            Debug.Log("Scene switching");
            SceneManager.LoadScene("ExplainScreen");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("InterObject"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObject"))
        {
            if (other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            Debug.Log(other.name);
        }
    }
}
