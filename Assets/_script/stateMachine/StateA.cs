using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateA : MonoBehaviour, IState
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void Handle(PlayerController playerController)
    {
        _animator.SetBool("Rumba", false);
        _animator.SetBool("Swing", false);
        _animator.SetBool("Capoeira", true);
    }
}
