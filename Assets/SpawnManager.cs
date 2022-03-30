using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    public playerMovement player;
    public Vector3 offset;
    public float safeMargin;
    public GameObject[] platform;
    public float spawnPoint = 0;
   
    // Start is called before the first frame update
    void Start()
    {
       // currentPlatform = Instantiate(platform[0], currentPlatform.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // 



        // Instantiate(obstacle,transform.position+offset,Quaternion.identity);

       
            int k = Random.Range(0,platform.Length);
            if(spawnPoint<5)
            {
                k = 0;
            }
        while (spawnPoint < player.transform.position.x + safeMargin)
        {
            GameObject currentPlatform = Instantiate(platform[k],transform.position, Quaternion.identity);
            PlatformController platform1 = currentPlatform.GetComponent<PlatformController>();
            currentPlatform.transform.position = new Vector3(spawnPoint + platform1.GetComponentInChildren<Transform>().localScale.x/2,0,0);

            // spawnPoint = 35;
            spawnPoint = spawnPoint + platform1.GetComponentInChildren<Transform>().localScale.x;

                }
            
    }
}

