using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Action�� System �ؿ� ����
using System;

public class Worker : MonoBehaviour
{
    Action work;

    /// <summary>
    /// <para>
    ///     ����� �޼����
    /// </para>
    /// </summary>
    private void MoveBricks()
    {
        Debug.Log("���� �Ű��");
    }

    private void DigIn ()
    {
        Debug.Log("���� �ʹ�");
    }

    /// <summary>
    /// <para>
    ///     int ���, int�� �� Func�� Prop �õ��غ� ����
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
    ///     ��� �� ����
    /// </para>
    /// </summary>
    private void Awake ()
    {
        work += MoveBricks;
        work += DigIn;

        payment += () => { return Pay; };
        int value = payment.Invoke();
        Debug.Log("Func Ÿ�� �õ�" + value);

        payment = null;

        payment += () => { return Pay = 140000; };
        value = payment.Invoke();
        Debug.Log("Func Ÿ�� �õ�" + value);
    }

    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            work?.Invoke();
        }
    }
}
