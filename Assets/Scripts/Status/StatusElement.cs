using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusElement : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private Sprite _icon;

    public void SetData(string value, Sprite icon = null)
    {
        Debug.Log(value);
        text.text = value;
    }

    public void SetDataAndEnable(string value, Sprite icon = null)
    {
        text.text = value;
        gameObject.SetActive(true);
    }

    public void DisableElement()
    {
        gameObject.SetActive(false);
    }
}
