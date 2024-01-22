using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// <para>
///     UnityEvent ����� ����س��� �� Ư�� �޼��� �ȿ��� Invoke�θ� ó����
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
