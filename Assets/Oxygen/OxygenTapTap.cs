using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OxygenTapTap : MonoBehaviour
{
    public GameObject tap, dropsAnimi, flask;

    public Animator ag;
    float d1 = 0.00f;
    public static double h1;
    public TextMesh value;



    public void Update()
    {

        rep();
        //OldValue.SetActive(true);
        tap.GetComponent<Animator>().enabled = true;
        tap.GetComponent<Animator>().Play("TAP");
        dropsAnimi.SetActive(true);

        ag.GetComponent<Animator>().enabled = true;
        ag.GetComponent<Animator>().Play("AGDown");



     

        flask.GetComponent<Animator>().enabled = true;



    }


    public void rep()
    {


        d1 += Time.deltaTime * 1.0f;
        h1 = Math.Round(d1, 2);

        value.text = h1.ToString();



    }
}
