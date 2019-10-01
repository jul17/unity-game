using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 180f;
    private Rigidbody body;


	void Start ()
    {
        body = GetComponent<Rigidbody>();
	}
	void Update ()
    {
        float movementInput = GetMovementInput();
        Vector3 movement = transform.forward * movementInput * speed * Time.deltaTime;
        body.MovePosition(body.position + movement);
        
        float rotationInput = GetRotationInput();
        float degreesToTurn = rotationInput * rotationSpeed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(0f, degreesToTurn, 0f);
        body.MoveRotation(body.rotation * rotation);

	}
    float GetMovementInput()
    {
        KeyCode positiveKey = KeyCode.UpArrow;
        KeyCode negativeKey = KeyCode.DownArrow;
        

        if (Input.GetKey(positiveKey))
        {
            return 1f;
        }
        else if (Input.GetKey(negativeKey))
        {
            return -1f;
        }
        else
        {
            return 0f;
        }
    }
    float GetRotationInput()
    {
        KeyCode positiveKey = KeyCode.RightArrow;
        KeyCode negativeKey = KeyCode.LeftArrow;

        if (Input.GetKey(positiveKey))
        {
            return 1f;
        }
        else if (Input.GetKey(negativeKey))
        {
            return -1f;
        }
        else
        {
            return 0f;
        }
    }
}