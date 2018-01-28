using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redPlaneMovementScript : MonoBehaviour {

    public Rigidbody rb;
    Quaternion forwardRotation;
    Quaternion downRotation;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        forwardRotation = Quaternion.Euler(0, 0, 60);
        downRotation = Quaternion.Euler(0, 0, -80);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(3f * Time.deltaTime, 0, 0);
        if (Input.GetMouseButtonDown(0))
        {
            rb.transform.rotation = forwardRotation;

            rb.velocity = new Vector2(0.41f, 6f);


        }
        rb.transform.rotation = Quaternion.Lerp(rb.transform.rotation, downRotation, 1.2f * Time.deltaTime);
        if (transform.position.y >= 5.5f || transform.position.y <= -6)
        {
            FindObjectOfType<gameManagerScript>().endGame();
        }
    }
}
