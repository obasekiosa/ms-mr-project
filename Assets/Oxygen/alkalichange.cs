using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alkalichange : MonoBehaviour
{
    public float speed = 50.0f;
    public Color startColor;
    public Color endCColor;
    public bool repeatable = false;
    float startTime;
    public GameObject alkali;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        //Color colorEnd = new Color(0.3687963f, 0.6509434f, 0.2916963f, 1.0f);


    }

    // Update is called once per frame
    void Update()
    {
        if (!repeatable)
        {

            float t = (Time.time - startTime) * speed;
            alkali.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endCColor, t);



        }
        else
        {
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            alkali.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endCColor, t);

        }






    }
}

