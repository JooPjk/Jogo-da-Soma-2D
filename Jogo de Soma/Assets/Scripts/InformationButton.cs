using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationButton : MonoBehaviour
{
    public GameObject informationText;
    private bool isTextVisible = false;

    public void ToggleInformation()
    {
        isTextVisible = !isTextVisible;
        informationText.SetActive(isTextVisible);
    }
}
