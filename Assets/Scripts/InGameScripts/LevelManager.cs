using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoSingleton<LevelManager>
{

    #region References

    private int _currentSceneIndex;


    #endregion


    private void Awake() => _currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    public void ReloadLevel() => SceneManager.LoadScene(_currentSceneIndex);

    public void NextLevel()
    {
        var sceneCount = SceneManager.sceneCountInBuildSettings;
        if (_currentSceneIndex + 1 >= sceneCount) return;
        SceneManager.LoadScene(_currentSceneIndex + 1);
    }
}
