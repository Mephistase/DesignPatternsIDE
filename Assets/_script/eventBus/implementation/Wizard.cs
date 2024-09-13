using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("MAGIC !");
            EventBus.InvokeEvent(EventEnum.Spell);
        }
    }
}
