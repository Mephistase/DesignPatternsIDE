using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniteBleu : EntityReceiver
{
    public override void ReceiveSpell()
    {
        if (_ready)
        {
            print("J'ai reçu un sort et je suis bleu !");
            Destroy(gameObject);
        }
            
    }
}
