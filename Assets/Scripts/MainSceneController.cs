using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    public Text nameTagText;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        nameTagText.text = playerName;
    }
}
