using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : CameraControl
{
    [SerializeField]
    CharacterController controller;
    public Transform playerBody;
    
    


  

    void Update()
    {
        PersonMovement();
    }

    void PersonMovement()
    {
        float movementX = Input.GetAxis("Horizontal");
        movementX *= Time.deltaTime;
        float movementY = Input.GetAxis("Vertical");
        movementY *= Time.deltaTime;
        Vector3 playerMove = transform.right * movementX + cam.transform.forward * movementY;
        playerMove += Physics.gravity;
        controller.Move(playerMove * 1000f * Time.deltaTime);
    }

   
}
