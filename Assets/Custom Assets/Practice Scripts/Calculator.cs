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
    ///     복합 실행 가능한지 따지기 위해 모두 전달해봤음
    /// </para>
    /// </summary>
    private void Start ()
    {
        onCalculate = Sum;
        onCalculate += Subtract;
        onCalculate += Multiply;
        onCalculate += Divide;
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
    ///     전달자에서 호출 및 할당 해제 해본 케이스
    /// </para>
    /// <para>
    ///     전달자에 여러 메서드가 전달되어도 호출 가능.
    ///     (파라미터 및 리턴 타입이 맞기 때문으로 생각됨)
    /// </para>
    /// <para>
    ///     키업 시 전달자에 메서드를 모두 -=으로 제거했고 null이 되었을 때도
    ///     ?.으로 호출 시도하기 때문에 에러는 피할 수 있음.
    /// </para>
    /// </summary>
    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            onCalculate?.Invoke(1, 10);

            if(onCalculate == null)
            {
                Debug.Log("메서드가 정상적으로 할당 해제됨");
            }

        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            onCalculate -= Sum;
            onCalculate -= Subtract;
            onCalculate -= Multiply;
            onCalculate -= Divide;
        }
    }
}