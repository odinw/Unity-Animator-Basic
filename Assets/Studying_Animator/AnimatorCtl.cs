using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorCtl : MonoBehaviour
{
    Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }


    /// <summary>
    /// 給 Animation 的 Event 使用
    /// </summary>
    public void Test()
    {
        Debug.Log("test");
    }

    public void SetTrigger_Scale_Roll() => _animator.SetTrigger("Scale_Roll");

    public void SetBool_IsScale(bool b) => _animator.SetBool("IsScale", b);

    public void SetFloat_Scale_Speed(float rate = 1) => _animator.SetFloat("Scale_Speed", rate);
}
