using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleToFlask : MonoBehaviour
{

    public GameObject FlaskLiq, newBottle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Stand")
        {
            FlaskLiq.SetActive(true);
            newBottle.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
