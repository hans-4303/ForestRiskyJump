using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    delegate float Calculate(float a, float b);

    Calculate onCalculate;

    /// <summary>
    /// <para>
    ///     �����ϴ� �������� ������ �ƴ�
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
    ///     ���� �Ʒ� ���� �۵��� �� �� ������ ������ ���̴�
    ///     � �Լ��� � �������� ���� �����ų�� �� �˾ƾ� ��
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
