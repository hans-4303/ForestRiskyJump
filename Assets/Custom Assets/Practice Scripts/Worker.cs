using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Action은 System 밑에 포함
using System;

public class Worker : MonoBehaviour
{
    Action work;

    /// <summary>
    /// <para>
    ///     실행될 메서드들
    /// </para>
    /// </summary>
    private void MoveBricks()
    {
        Debug.Log("블럭을 옮겼다");
    }

    private void DigIn ()
    {
        Debug.Log("땅을 팠다");
    }

    /// <summary>
    /// <para>
    ///     int 멤버, int형 및 Func형 Prop 시도해본 과정
    /// </para>
    /// </summary>
    private Func<int> payment;

    private int pay = 130000;

    public int Pay
    {
        get { return pay; }
        private set
        {
            if(pay <= value)
            {
                pay = value;
            }
        }
    }

    /// <summary>
    /// <para>
    ///     등록 후 실행
    /// </para>
    /// </summary>
    private void Awake ()
    {
        work += MoveBricks;
        work += DigIn;

        payment += () => { return Pay; };
        int value = payment.Invoke();
        Debug.Log("Func 타입 시도" + value);

        payment = null;

        payment += () => { return Pay = 140000; };
        value = payment.Invoke();
        Debug.Log("Func 타입 시도" + value);
    }

    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            work?.Invoke();
        }
    }
}
