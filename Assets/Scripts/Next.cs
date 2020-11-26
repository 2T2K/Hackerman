using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public GameObject firstText;
    public GameObject secondText;
    public GameObject button1;
    public GameObject button2;

    public void NextLine()
    {
        firstText.SetActive(false);
        secondText.SetActive(true);

        button1.SetActive(false);
        button2.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
