using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// <para>
///     UnityEvent 멤버를 등록해놓은 뒤 특정 메서드 안에서 Invoke로만 처리함
/// </para>
/// </summary>
public class PlayerHealth : MonoBehaviour
{
    public UnityEvent onPlayerDead;

    private void OnTriggerEnter (Collider other)
    {
        onPlayerDead.Invoke ();
        Debug.Log("YOU DIED");
        Object.Destroy(this.gameObject);
    }
}
