using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor : MonoBehaviour
{
    /// <summary>
    /// <para>
    ///     �̺�Ʈ�� ���� �ʴ´ٸ� Ŭ���� ���� �ν��Ͻ��� �˾ƾ� ��
    /// </para>
    /// </summary>
    public Booster booster;

    public string playerName = "Jonnie";

    public float hp = 100.0f;
    public float defense = 50.0f;
    public float damage = 30.0f;

    /// <summary>
    /// <para>
    ///     �̺�Ʈ ���� �������� ���� ������ ����
    /// </para>
    /// </summary>
    private void Awake ()
    {
        booster.HealthBoost(this);
    }
}
