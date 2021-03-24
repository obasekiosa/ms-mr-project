using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StarchToFlask : MonoBehaviour
{
    public GameObject tap, OldValue, paleYellow, blue, newStarch, MidValue;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Stand")
        {

            //tap.GetComponent<OxygenTapOff>().enabled = false;
            //tap.GetComponent<OxygenTapTap>().enabled = true;
            //OldValue.GetComponent<MeshRenderer>().enabled = false;
            MidValue.SetActive(false);

            paleYellow.SetActive(false);
            blue.SetActive(true);

            newStarch.SetActive(true);
            gameObject.SetActive(false);

        }
    }


}
