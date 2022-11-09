using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{

    public void GameStart()
    {

    }

    
    public void GameOver()
    {
        // To DO : gameover screen in UI manager.
        LevelManager.Instance.ReloadLevel();
    }

    public void GameFinish()
    {

    }
}
