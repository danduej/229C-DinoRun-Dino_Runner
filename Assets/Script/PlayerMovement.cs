using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 4; // ความเร็วเคลื่อนที่ไปข้างหน้า
    public float horizontalSpeed = 3; // ความเร็วคลื่อนที่ซ้าย - ขวา
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;

    void Update()
    {
        // ทำให้ตัวละครเคลื่อนที่ไปข้างหน้าแบบต่อเนื่อง
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        // เช็คว่า Player กดปุ่ม A หรือ คลิ๊กซ้าย
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
        }

        // เช็คว่า Player กดปุ่ม D หรือ คลิ๊กขวา
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
            }
        }
    }
}
