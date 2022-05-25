using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject bag;
    public GameObject passport;
    public GameObject food;
    public GameObject water;
    public CharacterController controller;
    
    public bool hasBag = false;
    public bool hasPassport = false;
    public bool hasFood = false;
    public bool hasWater = false;

    public float speed = 12f;
    public float gravity =-9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.6f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        hasBag = PlayerInfo.hasBag;
        hasFood = PlayerInfo.hasFood;
        hasPassport = PlayerInfo.hasPassport;
        hasWater = PlayerInfo.hasWater;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerInfo.hasWater);
        PlayerInfo.hasBag = hasBag;
        PlayerInfo.hasPassport = hasPassport;
        PlayerInfo.hasFood = hasFood;
        PlayerInfo.hasWater = hasWater;
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (!GameObject.Find("GameManager").GetComponent<GameManager>().paused)
        {
            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            if (Input.GetKeyDown("space") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
    }
}
