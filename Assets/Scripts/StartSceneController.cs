using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    public InputField nameInputField;

    public void OnJoinButtonClicked()
    {
        if (nameInputField.text.Length > 1 && nameInputField.text.Length < 11)
        {
            string playerName = nameInputField.text;

            PlayerPrefs.SetString("PlayerName", playerName);
            PlayerPrefs.Save();

            SceneManager.LoadScene("MainScene");
        }
    }
}