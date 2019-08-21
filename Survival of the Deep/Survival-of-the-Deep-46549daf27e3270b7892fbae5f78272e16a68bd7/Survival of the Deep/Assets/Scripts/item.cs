using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public enum State
    //numeration
    {
        randomColor,
        close,
        inbetween
    }

    public State state;
    // Start is called before the first frame update
    void Start()
    {
        state = item.State.close;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseEnter()
    {
        Debug.Log("Enter");
    }

    public void OnMouseExit()
    {
        Debug.Log("Exit");
    }

    public void OnMouseUp()
    {
        Debug.Log("Up");
        if (state == item.State.close)
            Red();
        else
            Close();
        //checking for function
    }

    private void Red()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        // change animation to changing color
        state = item.State.randomColor;
        
    } 

    private void Close()
    {
        gameObject.GetComponent<Renderer> ().material.color = Color.gray;
        state = item.State.close;
    }
}
