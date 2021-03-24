using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorani : MonoBehaviour
{
     public GameObject fup,fdwn;
    bool m;
    public void OnMouseDown()
    {
        m = !m;
        if (m)
        {
        fup.SetActive(true);
        fup.GetComponent<Animator>().enabled = true;
        fup.GetComponent<Animator>().Play("flooranim");

        }
        if (m == false)
        {
          //fup.SetActive(true);
        fdwn.GetComponent<Animator>().enabled = true;
        fdwn.GetComponent<Animator>().Play("flooranim2");

        }        
    }
}
