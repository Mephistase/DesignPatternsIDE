using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateUI : MonoBehaviour
{
    [SerializeField] private PlayerController _controller;
    private void OnGUI()
    {
        if(GUILayout.Button("Capoeira"))
        {
            _controller.CallStateA();
        }
        if (GUILayout.Button("Rumba"))
        {
            _controller.CallStateB();
        }
        if (GUILayout.Button("Swing"))
        {
            _controller.CallStateC();
        }
    }
}
