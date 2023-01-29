using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUiController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject movementKeys;
    public GameObject uiButtons;
    private GameObject player;


    private void Awake() 
    {
        gameOverPanel.SetActive(false);
        movementKeys.SetActive(true);
        uiButtons.SetActive(true);
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        if(player == null)
        {
        gameOverPanel.SetActive(true);
        movementKeys.SetActive(false);
        uiButtons.SetActive(false);
        Time.timeScale = 0f;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
