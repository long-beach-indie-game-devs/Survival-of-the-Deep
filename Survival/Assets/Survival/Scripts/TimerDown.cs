using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDown : MonoBehaviour
{
    float timeLeft = 30.0f;

    public void timeOff()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft< 0)
        {
            this.GetComponent<Light>().enabled = false;
        }
    }


    void Update()
    {
    }

}
