using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    /// <summary>
    /// Меняет уровень по имени
    /// </summary>
    /// <param name="name"> имя уровня</param>
    public void ChangeLevel(string name)
    {
        SceneManager.LoadScene(name); 
    }

    /// <summary>
    /// выход приложения из билда
    /// </summary>
    public void Exit()
    {
        Application.Quit(); 
    }

}
