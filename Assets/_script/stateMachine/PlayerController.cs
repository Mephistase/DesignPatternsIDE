using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerContext _playerContext;
    private IState _stateA, _stateB, _stateC;

    private void Start()
    {
        SetState();
    }

    private void SetState()
    {
        _playerContext = new PlayerContext(this);
        _stateA=gameObject.AddComponent<StateA>();
        _stateB = gameObject.AddComponent<StateB>();
        _stateC = gameObject.AddComponent<StateC>();
    }

    public void CallStateA()
    {
        _playerContext.Transition(_stateA);
    }

    public void CallStateB()
    {
        _playerContext.Transition(_stateB);
    }

    public void CallStateC()
    {
        _playerContext.Transition(_stateC);
    }
}
