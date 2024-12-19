using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30f;

    private float horizontalInput;
    private float verticalInput;

    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        playerRb.drag = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        GetMoveInput();
    }

    private void FixedUpdate()
    {

        MovePlayer();
    }

    void GetMoveInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer()
    {
        Vector3 move = transform.forward * verticalInput + transform.right * horizontalInput;

        move = move.normalized;

        playerRb.AddForce(move * speed, ForceMode.Force);
    }
}
