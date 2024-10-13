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
            Debug.LogError("timeText가 null입니다. Text 컴포넌트가 제대로 연결되었는지 확인하세요.");
        }
    }

    public static string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH : mm"));
    }
}