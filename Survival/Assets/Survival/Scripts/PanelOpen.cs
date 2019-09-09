using UnityEngine;
using UnityEngine.UI;

public class PanelOpen : MonoBehaviour
{
    public Canvas canvasPower ;

    public void open()
    {
        //erased escape to test the cursor 
        canvasPower.gameObject.SetActive(!canvasPower.gameObject.activeSelf);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            open();
        }
    }
}
