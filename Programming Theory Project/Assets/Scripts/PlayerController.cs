using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 60f; 
    private float airSpeed = 20f;
    private float jumpForce = 10f;

    private float horizontalInput;
    private float verticalInput;
    private bool ReadyToJump;

    private Rigidbody playerRb;
    private float playerHeight;

    public bool Grounded;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        playerRb.drag = 5f;

        Grounded = true;

        playerHeight = GetComponent<CapsuleCollider>().height;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.GAMEOVER)
        {
            GetPlayerInput();

            GroundCheck();

            Jump();

            DragCheck();
        }
    }

    private void FixedUpdate()
    {
        if(!GameManager.Instance.GAMEOVER)
        {
            MovePlayer();
        }
    }

    void GetPlayerInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        ReadyToJump = Input.GetKeyDown(KeyCode.Space);
    }

    void MovePlayer()
    {
        Vector3 move = transform.forward * verticalInput + transform.right * horizontalInput;

        move = move.normalized;

        if (!Grounded)
        {
            playerRb.AddForce(move * airSpeed, ForceMode.Force);
        }
        else
        {
            playerRb.AddForce(move * speed, ForceMode.Force);
        }
        
    }

    void Jump()
    {
        if (Grounded && ReadyToJump)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            Grounded = false;
        }
    }

    void DragCheck()
    {
        if (!Grounded)
        {
            playerRb.drag = 1.5f;
        }
        else
        {
            playerRb.drag = 5f;
        }
    }

    void GroundCheck()
    {
        float distance = playerHeight * 0.5f;
        float radius = 0.3f;
        RaycastHit hit;

        Grounded = Physics.SphereCast(transform.position, radius, Vector3.down, out hit, distance);
    }
}
