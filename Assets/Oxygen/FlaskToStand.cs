using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaskToStand : MonoBehaviour
{
    public GameObject Flask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Stand")
        {
            Flask.SetActive(true);
           
            gameObject.SetActive(false);
        }
    }

}
