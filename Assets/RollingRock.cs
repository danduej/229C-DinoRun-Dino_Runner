using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingRock : MonoBehaviour
{
    private Rigidbody rb;
    public float forceAmount = 1000f; // กำหนดแรงให้หินกลิ้งไปข้างหน้า

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 20f; // ตั้งมวลของก้อนหิน
        rb.AddForce(Vector3.forward * forceAmount); // ออกแรงไปข้างหน้า
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hit by rolling rock!");
            // เพิ่มเอฟเฟกต์หรือทำให้ผู้เล่นเสียพลังชีวิต
        }
    }
}