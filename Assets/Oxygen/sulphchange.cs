using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sulphchange : MonoBehaviour
{
    public GameObject mnso4;
    Color colorStart;
    Color colorEnd = Color.green;
    float duration = 50f;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        Color colorStart = new Color(0.9528302f, 0.9064313f, 0.4269758f, 0.454902f);

        //Color colorEnd = new Color(0.3687963f, 0.6509434f, 0.2916963f, 1.0f);


    }

    // Update is called once per frame
    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        mnso4.GetComponent<Renderer>().material.color = Color.Lerp(colorStart, colorEnd, lerp);


    }
}