using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GemTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("InterObject"))
        {
            Debug.Log(other.name);
            StartCoroutine(SceneChangeCoroutine());
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObject"))
        {
            Debug.Log(other.name);
        }
    }

    IEnumerator SceneChangeCoroutine()
    {
        Debug.Log("Scene change in 3, 2, 1...");

        yield return new WaitForSeconds(4);

        SceneManager.LoadScene("Game");
    }
}
