using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messenger : MonoBehaviour
{
    public delegate void Send (string reciever);

    Send onSend;

    private void SendMail(string reciever)
    {
        Debug.Log(reciever + "에게 씀");
    }

    private void SendMoney(string reciever)
    {
        Debug.Log(reciever + "에게 보냄");
    }

    /// <summary>
    /// <para>
    ///     람다 + delegate, 형식만 맞춘다면 메서드를 즉시 작성할 수도 있음
    /// </para>
    /// </summary>
    private void Awake ()
    {
        onSend += SendMail;
        onSend += SendMoney;
        onSend += (reciever) => { Debug.Log(reciever + "에게 이상한 소포"); };
    }

    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            onSend?.Invoke("Jonnie");
        }
    }
}
