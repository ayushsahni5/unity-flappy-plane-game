using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnObstaclesScript : MonoBehaviour {
    public cameraMovementScript cms;
    public GameObject preFab1;
    public GameObject[] rocks;
    private int rockSpawnymin = -3;
    private int rockSpawnymax = 3;
    private float rockSpawnyPosition;
    private float rockSpawnxPosition=12f;
    private Vector3 rockPosition = new Vector3(-20, -30, 0);
    private float spawnRate = 5f;
    private float timeSinceLastSpawned = 0;
    int currentRock = 0;
    // Use this for initialization
    void Start()
    {
        rocks = new GameObject[5];
        for (int i = 0; i < 5; i++)
        {
            rocks[i] = (GameObject)Instantiate(preFab1, rockPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-3f*Time.deltaTime, 0, 0);
        timeSinceLastSpawned += Time.deltaTime;
        if (timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            rockSpawnyPosition = Random.Range(rockSpawnymin, rockSpawnymax);
             rocks[currentRock].transform.position = new Vector3(cms.transform.position.x+rockSpawnxPosition, rockSpawnyPosition, 0);
             currentRock++;
             if (currentRock >= 5)
                 currentRock = 0;
            
            
        }

    }
}
