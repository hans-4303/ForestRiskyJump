using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public void HealthBoost(Charactor target)
    {
        Debug.Log(target.playerName + "ü�� ��ȭ");
        target.hp += 10;
    }

    public void ShieldBoost (Charactor target)
    {
        Debug.Log(target.playerName + "��� ��ȭ");
        target.defense += 10;
    }

    public void DamageBoost (Charactor target)
    {
        Debug.Log(target.playerName + "���ݷ� ��ȭ");
        target.damage += 10;
    }

    /// <summary>
    /// <para>
    ///     ������Ʈ�� ã�Ƽ� �޾ƿ� ���� playerBoost ����� �޼��常 �����صΰ� ����
    ///     ������ �÷��̾��� ����� �������� �ʴ� ȿ��
    /// </para>
    /// </summary>
    private void Awake ()
    {
        Charactor player = FindObjectOfType<Charactor>();

        player.playerBoost += HealthBoost;
        player.playerBoost += ShieldBoost;
        player.playerBoost += DamageBoost;
    }
}
