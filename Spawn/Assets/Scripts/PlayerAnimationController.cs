using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))] 

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayerWalkController()
    {
        _animator.SetFloat(AnimatorPlayerController.Params.Speed, 1f);
    }

    public void PlayerStayController()
    {
        _animator.SetFloat(AnimatorPlayerController.Params.Speed, 0f);
    }
}
