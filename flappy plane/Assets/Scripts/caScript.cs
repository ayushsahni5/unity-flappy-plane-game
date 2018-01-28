using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caScript : MonoBehaviour {                     //collsion action script

    void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<gameManagerScript>().endGame();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
            FindObjectOfType<gameManagerScript>().increaseScore();
    }
}
