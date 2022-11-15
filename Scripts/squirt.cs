using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squirt : MonoBehaviour
{

    public bool isOnGround;
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
            
        }
    }
}
