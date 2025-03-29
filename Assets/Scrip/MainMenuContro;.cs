using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }//เป็นคำลั่งที่ให้ปุ่มStartGame กลับไปยังSceneGamePlayที่เลือก
}