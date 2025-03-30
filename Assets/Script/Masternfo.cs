using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masternfo : MonoBehaviour
{
    public static int coinCount = 0;
    [SerializeField] GameObject coinDisplay;
    //แสดงUIของCoin
    
    void Update()
    {
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "COINS: " + coinCount;
    }   //แสดงกับการนับค่าCoinบนหน้าUI
}