using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed=1000;

    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityForce; 

    public bool isOnGround=true;
    // Start is called before the first frame update
    void Start()
    {
        playerRb=GetComponent<Rigidbody>();
        Physics.gravity*=gravityForce;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput=Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right*Time.deltaTime*horizontalInput*speed);
        
        if(Input.GetKeyDown(KeyCode.UpArrow)&& isOnGround){
            playerRb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround=false;
        }

        
    }

    private void OnCollisionEnter(Collision collision){
        isOnGround=true;
    }

    void onTriggerEnter(Collider other){
        if(other.gameObject.tag=="Powerup"){
            Destroy(other.gameObject);
        }
    }
        
}

