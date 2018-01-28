using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuScript : MonoBehaviour {
    private void Start()
    {
        Debug.Log("satrt");
    }
    public void menuClick()
    {
        Debug.Log("pg");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
