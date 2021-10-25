using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; set; } = null;

    public enum GameState
    {
        PREPARATION,
        RUNNING,
        END
    }
    
    public GameState gameState { get; set; } = GameState.PREPARATION;
    private const float preparationTime = 10;
    private float gameTimer { get; set; } = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gameTimer = preparationTime;
    }


    private void Update()
    {
        switch(gameState)
        {
            case GameState.PREPARATION:
                gameTimer -= Time.deltaTime;
                UIManager.instance.SetTimer(gameTimer);
                if(gameTimer <= 0)
                {
                    gameTimer = preparationTime;
                    gameState = GameState.RUNNING;
                }
            break;

            case GameState.RUNNING:

            break;

            case GameState.END:

            break;
        }
    }
}