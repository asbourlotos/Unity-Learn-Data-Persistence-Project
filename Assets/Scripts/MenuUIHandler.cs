using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    // This is the handler of the main menu scene
    [SerializeField] InputField NameInputField;

    // Start New Game
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // Set Player Name to Instance
    public void SetPlayerName()
    {
        PlayerDataHandler.Instance.PlayerName = NameInputField.text;
    }

    // Exit Game
    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
