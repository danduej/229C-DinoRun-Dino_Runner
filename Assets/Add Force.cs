using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class add : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collisionFX;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject fadeout;
    [SerializeField] GameObject rock1;
    [SerializeField] Rigidbody rockRb;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        // ตรวจสอบว่าชนกับ Player หรือไม่
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(CollisionEnd());
            rockRb.isKinematic = false;
            rockRb.AddForce(Vector3.left * 5, ForceMode.Impulse);
        }
    }
    IEnumerator CollisionEnd()
    {

        collisionFX.Play();
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        //เป็นคำสั่งที่ให้ทำให้ตัวหยุดขยับ

        playerAnim.GetComponent<Animator>().Play("Stumble Backwards");
        //เป็นการคำสั่งให้่เล่น Animation ของตัว Player ล้ม

        mainCam.GetComponent<Animator>().Play("ColilsionCam");
        //เป็นการคำสั่งให้่เล่น Animation ของmaincamera ให้สั่น

        mainCam.GetComponent<Animator>().Play("Credits Animation");
        //เป็นการคำสั่งให้่เล่น Animation ของฉากEndCredit ให้ตัวอักษรขยับ

        yield return new WaitForSeconds(3);
        fadeout.SetActive(true);
        //คำสั่งที่ทำให้ฉากFadeOut รอระยะ3วิ แล้วไปยังคำสั่้งถัดไป

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
        //คำสั่งรอระยะ3วิ เพื่อไปยังฉากที่ 3 แล้วไปยังคำสั่้งถัดไป

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
        //คำสั่งรอระยะ3วิ เพื่อไปยังฉากที่ 0 แล้วไปยังคำสั่้งถัดไป
    }

}
