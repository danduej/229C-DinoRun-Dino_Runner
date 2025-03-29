using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStartsControl : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void ReStarts()
    {
        SceneManager.LoadScene(1);
    }//เป็นคำลั่งที่ให้ปุ่มReStart กลับไปยังSceneGamePlayที่เลือก
}