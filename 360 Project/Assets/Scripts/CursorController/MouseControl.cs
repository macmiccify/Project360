using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{   
    private SpriteRenderer rend;
    public Sprite eyeCursor;
    public Sprite defaultCursor;
    private void Start()
    {
        Cursor.visible = false;
        rend = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

        if(Input.GetMouseButtonDown(0))
        {
            rend.sprite = eyeCursor;
        }else if(Input.GetMouseButtonUp(0))
        {
            rend.sprite = defaultCursor;
        }
    }
}
