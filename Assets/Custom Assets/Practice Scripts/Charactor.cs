using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor : MonoBehaviour
{
    /// <summary>
    /// <para>
    ///     ĳ���͸� �Ķ���ͷ� �޾� void�� ������ �޼��� ���� ���
    /// </para>
    /// </summary>
    public delegate void Boost (Charactor target);

    /// <summary>
    /// <para>
    ///     �� ������ ���� ��� �̺�Ʈ
    /// </para>
    /// </summary>
    public event Boost playerBoost;

    public string playerName = "Jonnie";

    public float hp = 100.0f;
    public float defense = 50.0f;
    public float damage = 30.0f;

    /// <summary>
    /// <para>
    ///     ��� �̺�Ʈ ȣ��
    /// </para>
    /// </summary>
    private void Start ()
    {
        playerBoost?.Invoke(this);
    }

    private void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerBoost?.Invoke(this);
        }
    }
}
