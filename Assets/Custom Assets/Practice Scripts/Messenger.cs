using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messenger : MonoBehaviour
{
    public delegate void Send (string reciever);

    Send onSend;

    private void SendMail(string reciever)
    {
        Debug.Log(reciever + "���� ��");
    }

    private void SendMoney(string reciever)
    {
        Debug.Log(reciever + "���� ����");
    }

    /// <summary>
    /// <para>
    ///     ���� + delegate, ���ĸ� ����ٸ� �޼��带 ��� �ۼ��� ���� ����
    /// </para>
    /// </summary>
    private void Awake ()
    {
        onSend += SendMail;
        onSend += SendMoney;
        onSend += (reciever) => { Debug.Log(reciever + "���� �̻��� ����"); };
    }

    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            onSend?.Invoke("Jonnie");
        }
    }
}
