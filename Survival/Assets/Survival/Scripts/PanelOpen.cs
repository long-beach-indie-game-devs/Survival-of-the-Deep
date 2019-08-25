using UnityEngine;
using UnityEngine.UI;

public class PanelOpen : MonoBehaviour
{
    public Canvas canvasPower;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvasPower.gameObject.SetActive(!canvasPower.gameObject.activeSelf);
        }
    }
}
