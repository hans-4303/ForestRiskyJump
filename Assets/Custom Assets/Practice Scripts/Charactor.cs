using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor : MonoBehaviour
{
    /// <summary>
    /// <para>
    ///     캐릭터를 파라미터로 받아 void로 끝내는 메서드 전달 허용
    /// </para>
    /// </summary>
    public delegate void Boost (Charactor target);

    /// <summary>
    /// <para>
    ///     위 형식을 갖는 멤버 이벤트
    /// </para>
    /// </summary>
    public event Boost playerBoost;

    public string playerName = "Jonnie";

    public float hp = 100.0f;
    public float defense = 50.0f;
    public float damage = 30.0f;

    /// <summary>
    /// <para>
    ///     멤버 이벤트 호출
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
