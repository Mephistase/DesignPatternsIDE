using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MagicButton : MonoBehaviour
{
    private bool _active = false;
    private void OnGUI()
    {
        if (_active)
        {
            if (GUILayout.Button("Stop", GUILayout.Width(100), GUILayout.Height(100)))
            {
                EventBus.InvokeEvent(EventEnum.Inactive);
                _active = false;
            }
            
        }
        else
        {
            if (GUILayout.Button("Start", GUILayout.Width(100), GUILayout.Height(100)))
            {
                EventBus.InvokeEvent(EventEnum.Active);
                _active = true;
            }
            
        }
    }

}
