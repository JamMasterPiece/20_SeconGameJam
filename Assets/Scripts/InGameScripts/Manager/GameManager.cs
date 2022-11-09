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
      print("Failed");
        LevelManager.Instance.ReloadLevel();
    }

    public void GameFinish() => LevelManager.Instance.NextLevel();
}
