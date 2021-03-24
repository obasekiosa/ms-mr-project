using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTapPlay : MonoBehaviour
{
    public GameObject tap, Firstvalue, Secondvalue, OldValue;

    bool b2;


    // Update is called once per frame
    public void OnMouseDown()
    {

        Firstvalue.SetActive(true);
        Secondvalue.SetActive(true);
        //OldValue.GetComponent<MeshRenderer>().enabled = false;


        b2 = !b2;
        if (b2)
        {
            tap.GetComponent<OxygenTapOff>().enabled = false;
            tap.GetComponent<OxygenTapTap>().enabled = true;
           

        }

        else if (b2 == false)
        {
            tap.GetComponent<OxygenTapOff>().enabled = true;
            tap.GetComponent<OxygenTapTap>().enabled = false;
            
        }
    }
}
