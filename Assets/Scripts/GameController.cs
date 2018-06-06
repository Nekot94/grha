using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text endText;
    
    public void Lose()
    {
        endText.text = "Т лшк ткй"; // меняет текст
        endText.color = Color.red; // меняет цвет текста
        StartCoroutine(Restart()); // запускает сопрограмму рестарт
    }

    public void Win()
    {
        endText.text = "Т пбдл"; // меняет текст
        endText.color = new Color(1, 0, 1); // меняет цвет текста
        StartCoroutine(Restart()); // запускает сопрограмму рестарт
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3); // ждет 3 секунды
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // перезагружает уровень
    }

}
