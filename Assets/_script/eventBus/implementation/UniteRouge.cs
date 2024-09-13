using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniteRouge : EntityReceiver
{
    [SerializeField]
    private GameObject[] _unitTypes;
    public override void ReceiveSpell()
    {
        if (_ready)
        {
            int index = Random.Range(0, _unitTypes.Length);
            Vector3 position = transform.position;
            position.x += Random.Range(-2.0f, 2.0f);
            position.y += Random.Range(-2.0f, 2.0f);
            position.z += Random.Range(-2.0f, 2.0f);
            Instantiate(_unitTypes[index], position, Quaternion.identity);
        }

    }
}