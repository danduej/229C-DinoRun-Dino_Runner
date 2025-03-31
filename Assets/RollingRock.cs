using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RollingRock : MonoBehaviour
{
    private Rigidbody rb;
    public float forceAmount = 4000f; // แรงที่ทำให้หินเคลื่อนที่

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 5f; // กำหนดมวลของหิน
        rb.AddForce(Vector3.left * forceAmount); // ออกแรงไปข้างหน้าให้หินกลิ้ง
    }

    //void OnCollisionEnter(Collision collision)
    //{
        //if (collision.gameObject.CompareTag("Dino")) // ถ้าหินชนผู้เล่น
        //{
            //Debug.Log("Player hit by rolling rock!");
            // ใส่โค้ดลดพลังชีวิตผู้เล่นตรงนี้ ถ้าต้องการ
       // }
   // }
}