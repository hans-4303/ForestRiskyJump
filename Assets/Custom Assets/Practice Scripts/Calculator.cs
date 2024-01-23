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
    ///     ���� ���� �������� ������ ���� ��� �����غ���
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
    ///     �����ڿ��� ȣ�� �� �Ҵ� ���� �غ� ���̽�
    /// </para>
    /// <para>
    ///     �����ڿ� ���� �޼��尡 ���޵Ǿ ȣ�� ����.
    ///     (�Ķ���� �� ���� Ÿ���� �±� �������� ������)
    /// </para>
    /// <para>
    ///     Ű�� �� �����ڿ� �޼��带 ��� -=���� �����߰� null�� �Ǿ��� ����
    ///     ?.���� ȣ�� �õ��ϱ� ������ ������ ���� �� ����.
    /// </para>
    /// </summary>
    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            onCalculate?.Invoke(1, 10);

            if(onCalculate == null)
            {
                Debug.Log("�޼��尡 ���������� �Ҵ� ������");
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