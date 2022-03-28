using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameStarted = false;
    [SerializeField] private Canvas titleCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isGameStarted() {
        return gameStarted;
    }

    public void StartGame()
    {
        gameStarted = true;
        titleCanvas.gameObject.SetActive(false);
    }
}
