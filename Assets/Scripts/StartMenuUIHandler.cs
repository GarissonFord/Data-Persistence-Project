using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartMenuUIHandler : MonoBehaviour
{
    public InputField nameInputField;

    public void StartGame()
    {
        NameManager.Instance.SetName(nameInputField.text);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
