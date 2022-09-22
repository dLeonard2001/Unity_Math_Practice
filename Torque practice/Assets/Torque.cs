using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{

    public Rigidbody playerRb;
    public int torqueSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && playerRb.velocity.magnitude < 15)
        {
            playerRb.AddForce(playerRb.transform.forward * torqueSpeed * 5, ForceMode.Force);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            playerRb.AddTorque(transform.up * torqueSpeed * -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRb.AddTorque(transform.up * torqueSpeed * 1);
        }
    }
}
