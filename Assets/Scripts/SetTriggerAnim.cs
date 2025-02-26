using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerAnim : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public ChangeSceneAfterSecond csas;
    public string triggerName;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetTriggerNow()
    {
        _animator.SetTrigger(triggerName);
    }

 }
