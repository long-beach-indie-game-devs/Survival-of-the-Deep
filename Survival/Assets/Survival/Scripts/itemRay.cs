using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class itemRay : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";

    public GameObject terminal;

    private bool selectTerminal;

    public enum State
    //numeration
    {
        randomColor,
        close,
        inbetween
    }


    public State state;
    // Start is called before the first frame update
   
    // Update is called once per frame
    

    public void OnMouseEnter()
    {
        Debug.Log("Enter");
    }

    public void OnMouseExit()
    {
        Debug.Log("Exit");
    }
   
    void Update ()
    {
        //huge problem, I got it to turn read when looking at it but now if player gets close to any object it turns red and the green function still works

        RaycastHit hit;
        var ray  = Camera.main.ScreenPointToRay(Input.mousePosition);

        //video varible "landingRay" is just the name of the ray 
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;

            if (Physics.Raycast(ray, out hit, 2))
            {
                Red();

                if (Input.GetButton("Fire1"))
                {
                    Green();
                        //make Green function
                }
            }
            else
            {
                Close();
            }
        }

    }

    public void OnMouseUp()
    {
        Debug.Log("Up");
    }

    private void Red()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        // change animation to changing color
        state = itemRay.State.randomColor;
        
    } 

    private void Close()
    {
        gameObject.GetComponent<Renderer> ().material.color = Color.gray;
        state = itemRay.State.close;
    }

    private void Green()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
