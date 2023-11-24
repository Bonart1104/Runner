using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Animation))]
public class Animation : MonoBehaviour
{
    private const string Idle = "Idle";
    private const string Run = "Run";

    private Animator _animation;

    private void Awake()
    {
        _animation = GetComponent<Animator>();
    }

    public void Idleed()
    {
        _animation.ResetTrigger(Run);
        _animation.SetTrigger(Idle);
    }

    public void Runing()
    {
        _animation?.ResetTrigger(Idle);
        _animation.SetTrigger(Run);
    }
}
