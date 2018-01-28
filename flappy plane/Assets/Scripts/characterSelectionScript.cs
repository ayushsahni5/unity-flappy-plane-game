using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class characterSelectionScript : MonoBehaviour {

    public static int count = 0;
    private GameObject[] characterList;

    private void Start()
    {
        characterList = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;

        }
        
        foreach (GameObject go in characterList)
            go.SetActive(false);

        if (characterList[0])
            characterList[0].SetActive(true);
    }

    public void changeCharater()
    {
        
        count++;
        if (count == 2)
            count = 0;
        if (count == 1)
        {
            characterList[1].SetActive(true);
            characterList[0].SetActive(false);
        }
        else if (count == 0)
        {
            characterList[1].SetActive(false);
            characterList[0].SetActive(true);
        }
        
    }
    public void changeScene()
    {
        SceneManager.LoadScene("sceneFinal1");
    }
}
