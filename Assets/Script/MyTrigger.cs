using UnityEngine;

public class MyTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.white;
        other.gameObject.GetComponent<Renderer>().material.color = Color.black;
    }
}///
