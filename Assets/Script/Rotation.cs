using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // ควบคุมความเร็วในการหมุนของวัตถุ
    [SerializeField] int rotateSpeed = 1;

    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime * 100, 0, Space.World);
    }
}
