using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{

    public float jumpForce;
    public float speed;
    Rigidbody rb;
    public Text Gameover;
    public Text scoretext;
    public float score;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void  Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(Vector3.up*jumpForce);
            
        }
        score = Mathf.Floor(transform.position.x);
        scoretext.text = score.ToString();

    }
    private void FixedUpdate()
    {
        
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Obstacle>()!=null)
        {
            Destroy(gameObject);
            Gameover.GetComponent<Text>().enabled = true;
        }
    }



}
