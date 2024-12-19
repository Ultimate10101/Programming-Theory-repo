using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    [SerializeField] GameObject gameCam;
    [SerializeField] GameObject player;

    float xRotation;
    float yRotation;

    int sensitivityX = 20;
    int sensitivityY = 20;

    // Start is called before the first frame update
    void Start()
    {
        gameCam.transform.position = transform.position;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxisRaw("Mouse X") * sensitivityX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensitivityY;

        yRotation += mouseX;
        xRotation -= mouseY;

        // Constraints X rotation; prevents player from looking more than 90 degrees
        xRotation = Mathf.Clamp(xRotation, -90, 90f);

        gameCam.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        player.transform.rotation = Quaternion.Euler(0,yRotation, 0);
    }

    void LateUpdate()
    {
        gameCam.transform.position = transform.position;
    }

}
