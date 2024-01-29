using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public void HealthBoost(Charactor target)
    {
        Debug.Log(target.playerName + "체력 강화");
        target.hp += 10;
    }

    public void ShieldBoost (Charactor target)
    {
        Debug.Log(target.playerName + "방어 강화");
        target.defense += 10;
    }

    public void DamageBoost (Charactor target)
    {
        Debug.Log(target.playerName + "공격력 강화");
        target.damage += 10;
    }

    /// <summary>
    /// <para>
    ///     컴포넌트를 찾아서 받아온 다음 playerBoost 멤버에 메서드만 대입해두고 끝냄
    ///     일일이 플레이어의 멤버에 접근하지 않는 효과
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
