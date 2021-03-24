using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class resultdisoxy : MonoBehaviour
{


    public InputField vol1;
    public InputField vol2;
    public InputField vol3;
    public InputField q;
    public Text ch, res;
    public GameObject print;


    public void OnMouseDown()
    {
        print.SetActive(true);
        double a = Convert.ToDouble(vol1.text);
        double b = Convert.ToDouble(vol2.text);
        double c = Convert.ToDouble(vol3.text);

        double d = ((b * c * 8 * 1000) / a);
        double rd2;
        rd2 = Math.Round(d, 2);
        ch.text = rd2.ToString();


        if (rd2 < 0)
        {
            res.text = ("Enter Correct Values");
            q.GetComponent<Image>().color = Color.red;
            res.GetComponent<Text>().color = Color.white;

        }
        else if (rd2 >= 0 && rd2 < 4)
        {
            res.text = ("The DO content present in the water is " + rd2 + " mg/l and check\nwith industrial practices.");
            q.GetComponent<Image>().color = Color.red;
            res.GetComponent<Text>().color = Color.white;
        }
        else if (rd2 >= 4)
        {
            res.text = ("The DO content present in the water is " + rd2 + " mg/l and check\nwith industrial practices.");
            q.GetComponent<Image>().color = Color.green;
            res.GetComponent<Text>().color = Color.black;
        }



    }




}