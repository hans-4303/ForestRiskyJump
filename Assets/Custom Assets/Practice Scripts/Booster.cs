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
}
