using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementSystem : MonoBehaviour
{
    public Text achievementText;

    public void UnlockAchievement(string title)
    {
        Debug.Log(title);
        achievementText.text = "�������� ����: " + title;
    }
}
