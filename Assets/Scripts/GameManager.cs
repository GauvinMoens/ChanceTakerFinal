using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] Animator lDoor;
    [SerializeField] Animator rDoor;
    [SerializeField] Animator cam;
    [SerializeField] GameObject mainMenu;

    public static GameManager instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
        }
    }

    public void PlayButton()
    {
        rDoor.SetBool("DoorOpened", true);
        lDoor.SetBool("DoorOpened", true);
        cam.SetBool("CameraMove", true);
        Invoke("DisableMainMenu", 1);
        Invoke("LaunchTheGame", 3);
    }

    public void DisableMainMenu() {
        mainMenu.SetActive(false);
    }


    public void LaunchTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +  1);
    }

    public void QuitButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
