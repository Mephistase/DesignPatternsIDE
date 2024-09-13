using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniteVert : EntityReceiver
{
    [SerializeField]
    private GameObject[] _unitTypes;
    public override void ReceiveSpell()
    {
        if (_ready)
        {
            print("Sort Vert !");
            int position = Random.Range(0, _unitTypes.Length);
            Instantiate(_unitTypes[position], transform.position,Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
