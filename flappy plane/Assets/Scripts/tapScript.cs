using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapScript : MonoBehaviour {

    int t = 0;
    private GameObject[] characterList2;

    private void Start()
    {
        characterList2 = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList2[i] = transform.GetChild(i).gameObject;

        }
        
    }
    private void Update()
    {

        if (t == 0)
        {
            characterList2[0].SetActive(true);
            characterList2[1].SetActive(false);
        }
        t++;
        if (t == 30)
        {
            characterList2[0].SetActive(false);
            characterList2[1].SetActive(true);
        }
        if (t == 60)
            t = 0;
    }
}
