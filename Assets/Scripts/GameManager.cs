using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameStarted = false;
    [SerializeField] private Canvas titleCanvas;
    [SerializeField] private Canvas gameCanvas;
    [SerializeField] private GameObject helpText;

    public bool isGameStarted() {
        return gameStarted;
    }

    public void StartGame()
    {
        gameStarted = true;
        titleCanvas.gameObject.SetActive(false);
        gameCanvas.gameObject.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ToggleHelp()
    {
        helpText.SetActive( !helpText.activeSelf);
    }
}
