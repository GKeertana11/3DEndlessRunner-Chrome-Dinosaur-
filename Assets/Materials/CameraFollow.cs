using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   // public GameObject player;
 public  playerMovement player;
   public Camera cam;
   // public Vector3 offset;
   

    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.Find("Player").GetComponent<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {

            cam.transform.position = new Vector3(player.transform.position.x, cam.transform.position.y,cam.transform.position.z);
                
        }
    }
}



