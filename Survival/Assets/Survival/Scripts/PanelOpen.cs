using UnityEngine;
using UnityEngine.UI;

public class PanelOpen : MonoBehaviour
{
    public Canvas canvasPower;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            //erased escape to test the cursor visible
        {
            canvasPower.gameObject.SetActive(!canvasPower.gameObject.activeSelf);
        }
    }

}
