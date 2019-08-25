using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpen : MonoBehaviour
{
    public CanvasPower canvasPower;

    private void Update()
    {
        if(Input.GetkeyDown(KeyCode.Escape))
        {
        PanelOpen.gameObject.SetActive(!canvasPower.gameObject.activeSelf);
        }

    }
}
