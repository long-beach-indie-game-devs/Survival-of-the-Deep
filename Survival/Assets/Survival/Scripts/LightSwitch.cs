using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
            this.GetComponent<Light>().enabled = true;
        if (Input.GetKey(KeyCode.L))
            this.GetComponent<Light>().enabled = false;
    }
}
