using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Collections;
public class gameManagerScript : MonoBehaviour {

    public Text highScore;
    public bool gameOver = false;
    public int score = 0;
    private GameObject[] characterListGameScene;                               //list of characters in game scene
    int flag = 0;
    GameObject Canvas;
    private void Start()
    {
        highScore.text=PlayerPrefs.GetInt("HighScore",0).ToString();
        
        characterListGameScene = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            characterListGameScene[i] = transform.GetChild(i).gameObject;

        }
        
        if (characterSelectionScript.count == 0)
        {
            
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (characterSelectionScript.count == 1)
        {
            
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(false);
        }

    }
    public void endGame()
    {

        if (flag == 0)
        {
            
            gameOver = true;
            respawn();
        }

    }
    public void respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void increaseScore()
    {
        
        score++;
        FindObjectOfType<scoreScript>().updateScore(score);
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
