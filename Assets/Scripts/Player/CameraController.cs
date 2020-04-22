using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSpeed = 100f;
    public Transform playerBody;

    public Transform gun;

    float gunXRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);

        gunXRotation -= mouseY;
        gunXRotation = Mathf.Clamp(gunXRotation, -90f, 25f);

        gun.localRotation = Quaternion.Euler(gunXRotation, 0f, 0f);

    }
}
