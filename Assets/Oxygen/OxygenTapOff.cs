using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTapOff : MonoBehaviour
{
    public GameObject tap, dropsAnimi, ag, flask;


    void Update()
    {
        tap.GetComponent<Animator>().Play("tapclose");
        dropsAnimi.SetActive(false);
        ag.GetComponent<Animator>().enabled = false;
        flask.GetComponent<Animator>().enabled = false;
    }
}
