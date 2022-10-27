/*
 * (Colin Gamagami)
 * (Assignment 5B)
 * (handles movement of the camera)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private float mouseSensitivity = 1000f;
    public GameObject player;
    private float verticalLookRotation = 0f;

    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        player.transform.Rotate(Vector3.up * mouseX);

        verticalLookRotation -= mouseY;

        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }

}
