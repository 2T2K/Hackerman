using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIdeInputLvl1 : MonoBehaviour
{
    public GameObject inputField;
    public GameObject hideField;
    public GameObject showField;
    public GameObject interObj;

    public void Hide()
    {
        inputField.SetActive(false);
        hideField.SetActive(false);
        showField.SetActive(true);
        interObj.SetActive(true);
    }

    public void Reveal()
    {
        inputField.SetActive(true);
        hideField.SetActive(true);
        showField.SetActive(false);
        interObj.SetActive(false);
    }
}
