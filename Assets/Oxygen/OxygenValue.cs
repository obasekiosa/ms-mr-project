using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OxygenValue : MonoBehaviour
{
    public GameObject tap, MIDVALUE, PaleYellow, Yellow, colorLess, Blue, tabCube;
    float BuretteValue1;
    double h1;
    public TextMesh MidValue;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "FirstValue")
        {
            tap.GetComponent<OxygenTapOff>().enabled = true;
            tap.GetComponent<OxygenTapTap>().enabled = false;

            BuretteValue1 = UnityEngine.Random.Range(1.0f, 1.5f);
            h1 = Math.Round(BuretteValue1, 1);

            MidValue.text = h1.ToString("0.0");
            //MIDVALUE.SetActive(true);

            PaleYellow.SetActive(true);
            Yellow.SetActive(false);

        }


        else if (col.gameObject.tag == "SecondValue")
        {
            tap.GetComponent<OxygenTapOff>().enabled = true;
            tap.GetComponent<OxygenTapTap>().enabled = false;

            BuretteValue1 = UnityEngine.Random.Range(6.0f, 10.0f);
            h1 = Math.Round(BuretteValue1, 1);

            MidValue.text = h1.ToString("0.0");
            //MIDVALUE.SetActive(true);

            Blue.SetActive(false);
            colorLess.SetActive(true);

            tabCube.SetActive(false);

        }
    }
}
