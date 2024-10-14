using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject penguin;
    public GameObject wizzard;

    private int characteridx = 0;

    private void Start()
    {
        characteridx = PlayerPrefs.GetInt("SelectedCharacter", 0);
        ActivateCharacter();
    }

    public void PenguinSelect()
    {
        characteridx = 0;
        PlayerPrefs.SetInt("SelectedCharacter", characteridx); 
        SceneManager.LoadScene("StartScene");
    }

    public void WizzardSelect()
    {
        characteridx = 1;
        PlayerPrefs.SetInt("SelectedCharacter", characteridx); 
        SceneManager.LoadScene("StartScene");
    }

    private void ActivateCharacter()
    {
        penguin.SetActive(false);
        wizzard.SetActive(false);

        if (characteridx == 0)
        {
            penguin.SetActive(true);
        }
        else if (characteridx == 1)
        {
            wizzard.SetActive(true);
        }
    }

    public void CharacterMenu()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
