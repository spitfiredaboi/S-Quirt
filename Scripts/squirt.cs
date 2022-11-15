using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squirt : MonoBehaviour
{
    //movement
    public float jumpForceUp;
    public float jumpForceDown;
    public float jumpForceForward;
    public float jumpForceRight;
    public float jumpForceLeft;

    //bools
    public bool isOnGround;
    
    //player
    public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("UpLeft") && isOnGround == true)
                {

            isOnGround = false;
            playerRb.AddRelativeForce(Vector3.up * jumpForceUp, ForceMode.Impulse);
            playerRb.AddRelativeForce(Vector3.forward * jumpForceForward, ForceMode.Impulse);
            playerRb.AddRelativeForce(Vector3.left * jumpForceLeft, ForceMode.Impulse);
            
        }
    }
}
