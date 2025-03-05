using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;
    public GameObject options;
    public GameObject about;

    [Header("Main Menu Buttons")]
    public Button startButton1;
    public Button startButton2;
    public Button optionButton;
    public Button aboutButton;
    public Button quitButton;

    public List<Button> returnButtons;

    // Start is called before the first frame update
    void Start()
    {
        EnableMainMenu();

        //Hook events
        // startButton1.onClick.AddListener(StartGame1);
        // startButton2.onClick.AddListener(StartGame2);
        // optionButton.onClick.AddListener(EnableOption);
        // aboutButton.onClick.AddListener(EnableAbout);
        // quitButton.onClick.AddListener(QuitGame);

        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableMainMenu);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame1()
    {
        Debug.Log("asdhdj"
        );
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(0); //WHAT TO WRITE HERE?
    }

public void StartGame2()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(1); //WHAT TO WRITE HERE?
    }

    public void HideAll()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
        about.SetActive(false);
    }

    public void EnableMainMenu()
    {
        mainMenu.SetActive(true);
        options.SetActive(false);
        about.SetActive(false);
    }
    public void EnableOption()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);
        about.SetActive(false);
    }
    public void EnableAbout()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
        about.SetActive(true);
    }
}
