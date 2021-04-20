using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 direction;
    public float speed = 8;
    public float jumpSpeed = 40;
    public float gravity = -20;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public ParticleSystem ps1;
    public ParticleSystem ps2;
    //public ParticleSystem ps3;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        direction.x = hInput * speed;
        bool isGrounded = Physics.CheckSphere(groundCheck.position,0.15f,groundLayer);
        direction.y += gravity * Time.deltaTime;
        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                direction.y = jumpSpeed;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ps1.Play();
        }

        if (Input.GetKeyUp(KeyCode.Q)&&ps1.isPlaying)
        {
            ps1.Stop();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ps2.Play();
        }

        if (Input.GetKeyUp(KeyCode.E) && ps2.isPlaying)
        {
            ps2.Stop();
        }
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            ps3.Play();
        }

        if (Input.GetKeyUp(KeyCode.R) && ps3.isPlaying)
        {
            ps3.Stop();
        }*/


        controller.Move(direction * Time.deltaTime);
    }
    void FixedUpdate()
    {
        
    }
}
