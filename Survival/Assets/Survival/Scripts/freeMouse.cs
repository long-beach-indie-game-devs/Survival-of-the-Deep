using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//youtube video [23] Cursor Lock State - How To Make A Game: https://www.youtube.com/watch?v=47MJ-WWNYRk
public class freeMouse : MonoBehaviour
{

    private bool isCursorLocked;


    private void Start()
    {
        ToggleCursorState();
    }
    private void Update()
    {
        CheckforInput();
        CheckifCursorShouldBeLocked();
    }

    // Start is called before the first frame update
    void ToggleCursorState()
    {
        isCursorLocked = !isCursorLocked;
    }

    void CheckforInput()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ToggleCursorState();
        }
    }
    
    void CheckifCursorShouldBeLocked()
    {
        if(isCursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
