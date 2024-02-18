using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public bool mouseEnable=false;

    void Start()
    {
        bool mouseEnable=false;
    }
        
    void Update()
    {
        // Movement
        float horizontalMove = Input.GetKey(KeyCode.A) ? -1f : (Input.GetKey(KeyCode.D) ? 1f : 0f);
        float verticalMove = Input.GetKey(KeyCode.S) ? -1f : (Input.GetKey(KeyCode.W) ? 1f : 0f);
        Vector3 movement = new Vector3(horizontalMove, 0f, verticalMove) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Rotation
        float horizontalRotate = Input.GetKey(KeyCode.LeftArrow) ? -1f : (Input.GetKey(KeyCode.RightArrow) ? 1f : 0f);
        float verticalRotate = Input.GetKey(KeyCode.UpArrow) ? -1f : (Input.GetKey(KeyCode.DownArrow) ? 1f : 0f);
        transform.Rotate(verticalRotate* rotationSpeed * Time.deltaTime/2, horizontalRotate * rotationSpeed * Time.deltaTime/2, 0f);


        if (Input.GetKey(KeyCode.Q))
        {
            mouseEnable=true;
        }

        if (Input.GetKey(KeyCode.E))
        {
            mouseEnable=false;
        }


        if (mouseEnable)
        {
        float mouseX = Input.GetAxis("Mouse X");

        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(-mouseY* rotationSpeed *10* Time.deltaTime/2, mouseX *10* rotationSpeed * Time.deltaTime/2, 0f);

        }

        
    }
}

