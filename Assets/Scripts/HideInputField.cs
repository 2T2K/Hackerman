using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideInputField : MonoBehaviour
{
    public GameObject inputField;
    public GameObject hideField;
    public GameObject showField;

    public void Hide()
    {
        inputField.SetActive(false);
        hideField.SetActive(false);
        showField.SetActive(true);
    }

    public void Reveal()
    {
        inputField.SetActive(true);
        hideField.SetActive(true);
        showField.SetActive(false);
    }
}
