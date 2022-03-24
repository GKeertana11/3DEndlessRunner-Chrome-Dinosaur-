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
   public GameObject currentPlatform;
    // Start is called before the first frame update
    void Start()
    {
        currentPlatform = Instantiate(platform[0], currentPlatform.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // 



        // Instantiate(obstacle,transform.position+offset,Quaternion.identity);

        while (spawnPoint < player.transform.position.x + safeMargin)
        {
            int k = Random.Range(0, platform.Length);
            currentPlatform = Instantiate(platform[k],currentPlatform.transform.position, Quaternion.identity);
            PlatformController platformController = currentPlatform.GetComponent<PlatformController>();
            currentPlatform.transform.position = new Vector3(spawnPoint + (platformController.platformSize / 2),0,0);
                }
            
    }
}
