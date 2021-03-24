using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakerToBurette : MonoBehaviour
{
    public GameObject ag, newBeaker;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Stand")
        {
            ag.SetActive(true);
            
            newBeaker.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
