using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor : MonoBehaviour
{
    /// <summary>
    /// <para>
    ///     이벤트를 쓰지 않는다면 클래스 내지 인스턴스를 알아야 함
    /// </para>
    /// </summary>
    public Booster booster;

    public string playerName = "Jonnie";

    public float hp = 100.0f;
    public float defense = 50.0f;
    public float damage = 30.0f;

    /// <summary>
    /// <para>
    ///     이벤트 쓰지 않음으로 인해 일일이 접근
    /// </para>
    /// </summary>
    private void Awake ()
    {
        booster.HealthBoost(this);
    }
}
