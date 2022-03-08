using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetViewCamera : MonoBehaviour
{
    [SerializeField] Transform playerCamera = null;
    [SerializeField] float mouseSensitivity = 1f;
    [SerializeField] bool lockCursor = true;
    float cameraPitch = 5.0f;
    private void Start()
    {
        if(lockCursor)
        {
            Cursor.lockState= CursorLockMode.Locked;
            Cursor.visible = true;
        }
    }
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
         Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"));
        cameraPitch -= mouseDelta.y*mouseSensitivity;
        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);
        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * mouseDelta.x * mouseSensitivity);
        }
    }
}
