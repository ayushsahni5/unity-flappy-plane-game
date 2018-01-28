using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMovementScript : MonoBehaviour {

	
	void Update () {
        transform.Translate(3f * Time.deltaTime, 0, 0);
    }
}
