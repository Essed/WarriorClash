using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
       
    // основные параметры
    [SerializeField]
    private float speed = 0f; // скорость передвижения
    [SerializeField]
    private float offsetX = 0f; // смещение по оси X
    [SerializeField]
    private float offsetZ = 0f; // смещение по оси Z   


    // параметры геймплея камеры
    [SerializeField]
    private Transform player = null; // игрок
    private float movementX = 0f; // позиция камеры по оси X
    private float movementZ = 0f; // позиция камеры по оси Z   

    private void LateUpdate()
    {
        if (player != null)
        {
            Folow();
        }       
    }

    // Метод следования за объектов
    private void Folow()
    {
        movementX = player.position.x + offsetX - transform.position.x;
        movementZ = player.position.z + offsetZ - transform.position.z;

        transform.position += new Vector3(movementX * speed * Time.deltaTime, 0, movementZ * speed * Time.deltaTime);
    }         

}
