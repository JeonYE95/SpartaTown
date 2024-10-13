using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject penguin;
    public GameObject wizzard;

    private int characteridx = 0;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        ActivateCharacter();
    }

    public void PenguinSelect()
    {
        characteridx = 0;
        SceneManager.LoadScene("StartScene");
    }

    public void WizzardSelect()
    {
        characteridx = 1;
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
