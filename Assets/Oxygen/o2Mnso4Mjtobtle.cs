using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o2Mnso4Mjtobtle : MonoBehaviour
{
    public GameObject mnso4liq, alkaliliq, sulphuricliq, brown, white, yellow, topTransp, newJar;
    


    //public GameObject[] List1;

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "btle")
        {

			//List1[Random.Range(0,List1.Length)].SetActive(true);
			
            if (o2mnso4tomj.i == 1)

            {
                mnso4liq.SetActive(false);
                newJar.SetActive(true);
                gameObject.SetActive(false);

            }

            else if (o2mnso4tomj.i == 2)
            {


                alkaliliq.SetActive(false);
                white.SetActive(false);
                brown.SetActive(true);
                topTransp.SetActive(true);
                gameObject.GetComponent<CountScript>().enabled = true;
                newJar.SetActive(true);
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                Invoke("AniPlay", 5);

               
            }

            else if (o2mnso4tomj.i == 3)
            {

                brown.SetActive(false);
                topTransp.SetActive(false);
                yellow.SetActive(true);
                sulphuricliq.SetActive(false);
                gameObject.SetActive(false);
            }

            

        }

    }

    void AniPlay()
    {
        brown.GetComponent<Animator>().enabled = true;
        topTransp.GetComponent<Animator>().enabled = true;
        gameObject.SetActive(false);
    }

    //void Update()
    //{
    //    i += Time.deltaTime * 1;
    //    countText.text = Mathf.Round(i).ToString();
    //}
}
   



