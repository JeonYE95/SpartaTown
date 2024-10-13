using System;
using UnityEngine;
using UnityEngine.UI;

public class DeltaTimeNow : MonoBehaviour
{
    private Text timeText;

    private void Awake()
    {
        timeText = transform.GetComponent<Text>();
    }

    private void Update()
    {
        if (timeText != null)
        {
            timeText.text = GetCurrentDate();
        }
        else
        {
            Debug.LogError("timeText�� null�Դϴ�. Text ������Ʈ�� ����� ����Ǿ����� Ȯ���ϼ���.");
        }
    }

    public static string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH : mm"));
    }
}