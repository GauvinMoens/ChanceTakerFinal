using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
        }
    }

    public void PlayButton()
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
