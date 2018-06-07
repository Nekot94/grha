using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public float rotSpeed = 100;
    public float jumpSpeed = 30;
    GameController gameController;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // величина перемещения 
        float movZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float movY = 0;
        float rotY = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime; // величина прыжка
        
        if (Input.GetButtonDown("Jump")) // если нажата клавиша прыжка
        {
            movY = jumpSpeed * Time.deltaTime; // меняем значение на скорость прыжка
        }
        transform.Translate(0, movY, movZ); // перемещает объект
        transform.Rotate(0, rotY, 0); // поворачивает объект

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") // проверяем обьект столкновеня на соответсвие тэгу
        {
            Debug.Log("Ты умер");
            // GetComponent<Renderer>().material.color = Color.red; // получаем компонент рендерер и меняем цвет у материала
            // Time.timeScale = 0; // останавливаем вреям в игре
            gameController.Lose(); // Проигрываем
            enabled = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finish")
        {
            // Time.timeScale = 0; // останавливаем время в игре
            gameController.Win(); // Побеждаем
            enabled = false;
        }
    }
}
