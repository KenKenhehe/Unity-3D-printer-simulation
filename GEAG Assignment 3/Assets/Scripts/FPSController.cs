using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    public float moveSpeed;
    public float mouseSen;
    Rigidbody rb;
    CharacterController controller;

    float xRotation;
    public bool FlyMode = false;
    Vector3 movement;
    public float gravity = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
        if (FlyMode == true)
        {
            rb.useGravity = false;
        }
        else
        {
            rb.useGravity = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerLook();
        PlayerMove();

    }

    void PlayerLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSen * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSen * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.Rotate(Vector3.up * mouseX);
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

    }

    void PlayerMove()
    {
        float movementForward = Input.GetAxis("Vertical");
        float movementHorizontal = Input.GetAxis("Horizontal");

        if (FlyMode == true)
        {
            movement = transform.right * movementHorizontal + Camera.main.transform.forward * movementForward;

        }
        else
        {
            movement = transform.right * movementHorizontal + transform.forward * movementForward;
            movement.y -= gravity * Time.fixedDeltaTime;
        }
        controller.Move(movement * moveSpeed * Time.deltaTime);
    }
}
