using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    delegate float Calculate(float a, float b);

    Calculate onCalculate;

    /// <summary>
    /// <para>
    ///     전달하는 문법이지 실행이 아님
    /// </para>
    /// </summary>
    private void Start ()
    {
        onCalculate = Sum;
    }

    public float Sum(float a, float b)
    {
        Debug.Log(a + b);
        return a + b;
    }

    public float Subtract(float a, float b)
    {
        Debug.Log(a - b);
        return a - b;
    }

    public float Multiply(float a, float b)
    {
        Debug.Log(a * b);
        return a * b;
    }

    public float Divide(float a, float b)
    {
        Debug.Log(a / b);
        return a / b;
    }

    /// <summary>
    /// <para>
    ///     물론 아래 같이 작동은 할 수 있지만 전달자 없이는
    ///     어떤 함수를 어떤 내용으로 언제 실행시킬지 다 알아야 함
    /// </para>
    /// </summary>
    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Sum(1, 10);
            Subtract(1, 10);
            Multiply(1, 10);
            Divide(1, 10);
        }
    }
}
