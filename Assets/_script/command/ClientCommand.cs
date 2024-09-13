using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClientCommand : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textGUI = null;
    
    private void OnGUI()
    {
        if(GUILayout.Button("Play Speech Command"))
        {
            PlayCommand();
        }
        if (GUILayout.Button("Undo"))
        {
            UndoCommand();
        }
    }
    private void PlayCommand()
    {
        ICommand command = new SpeechCommand(_textGUI);
        CommandInvoker.ExecuteCommand(command);
    }
    private void UndoCommand()
    {
        CommandInvoker.UndoCommandFn();
    }
}
