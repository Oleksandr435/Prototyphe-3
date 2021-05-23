using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerControlleer PlayerControlleerScript;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        PlayerControlleerScript = GameObject.Find("Player").GetComponent<PlayerControlleer>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObstacle()
    {
        if (PlayerControlleerScript.gameOver == false) 
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
