using UnityEngine;

public class MyConlision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.yellow;
        collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }//

}
