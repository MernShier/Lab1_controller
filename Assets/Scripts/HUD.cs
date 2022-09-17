using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private GameObject inputStatusText;
    public void ChangeInputStatusText()
    {
        switch (inputStatusText.activeSelf)
        {
            case true:
                inputStatusText.SetActive(false);
                break;
            case false:
                inputStatusText.SetActive(true);
                break;
        }
    }
}