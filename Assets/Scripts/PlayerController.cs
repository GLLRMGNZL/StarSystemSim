using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 10f;

    private float moveX;
    private float moveY;
    private float moveZ;

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        moveY = 0f;

        if (Input.GetKey(KeyCode.Space)) moveY = 1f;
        if (Input.GetKey(KeyCode.LeftControl)) moveY = -1f;

        Vector3 movement = new Vector3(moveX, moveY, moveZ).normalized;
        transform.position += transform.TransformDirection(movement) * movementSpeed * Time.deltaTime;
    }
}
