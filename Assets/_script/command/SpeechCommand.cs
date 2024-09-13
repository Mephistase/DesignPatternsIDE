using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeechCommand : MonoBehaviour, ICommand
{
    [SerializeField] private TextMeshProUGUI _textGUI = null;
    private string _text = "Speech";

    public SpeechCommand(TextMeshProUGUI textGUI)
    {
        _textGUI = textGUI;
    }
    public void Execute()
    {
        _textGUI.text = _text;
    }
    public void Undo()
    {
        _textGUI.text = "";
    }
}
