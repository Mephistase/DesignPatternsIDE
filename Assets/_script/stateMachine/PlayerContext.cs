using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContext 
{
    [SerializeField]
    private PlayerController _controller = null;
    private IState _currentState = null;
    //constructor
    public PlayerContext(PlayerController controller)
    {
        _controller = controller;
    }

    public void Transition(IState state)
    {
        _currentState = state;
        state.Handle(_controller);
    }
 
}
