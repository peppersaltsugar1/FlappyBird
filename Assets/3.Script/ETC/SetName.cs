using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    public InputField inputfield;
    public Text inputName;

    public void SetInputName()
    {
        UIManager.instance.SetName(inputName.text);
        inputfield.gameObject.SetActive(false);
    }

    public void Onclick()
    {
        TouchScreenKeyboard.Open(" ", TouchScreenKeyboardType.ASCIICapable);
    }
}
