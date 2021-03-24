using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTitration : MonoBehaviour
{

    public GameObject brown, pipe, flaskAnim, drops, brownFlask, paleYellow;

    // Update is called once per frame
    void Update()
    {
        if(brown.activeInHierarchy == true && pipe.activeInHierarchy == true)
        {
            Invoke("anima", 2);
            Invoke("aniStop", 8);
        }
    }

    void anima()
    {

        pipe.GetComponent<Animator>().Play("SodThio2");
        flaskAnim.GetComponent<Animator>().enabled = true;
        drops.SetActive(true);
    }

    void aniStop()
    {
        flaskAnim.GetComponent<Animator>().enabled = false;
        pipe.GetComponent<Animator>().enabled = false;
        //pipe.SetActive(false);
        drops.SetActive(false);
        brownFlask.SetActive(false);
        paleYellow.SetActive(true);
    }

}
