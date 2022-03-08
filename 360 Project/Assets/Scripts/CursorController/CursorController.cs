using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{   public Texture2D cursorDefault, cursorView, cursorZoom;
    private void ChangeCursor(Texture2D cursorType)
    {
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(cursorView, Vector2.zero, CursorMode.ForceSoftware);
        }else if(Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.ForceSoftware);
        }
        if(Input.GetMouseButtonDown(1))
        {
            Cursor.SetCursor(cursorZoom, Vector2.zero, CursorMode.ForceSoftware);
        }else if(Input.GetMouseButtonUp(1))
        {
            Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.ForceSoftware);
        }
    }
    private void Start()
    {
        ChangeCursor(cursorDefault);
        Cursor.lockState = CursorLockMode.Confined;
    }
}
