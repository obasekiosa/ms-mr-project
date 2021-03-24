using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o2mnso4tomj : MonoBehaviour
{
    public GameObject S1,S2, S3, newMnso4, newalkali, newsulphuric;
	public string elem;
	public static int i;
    
	
    void OnTriggerEnter(Collider col)
    {

        //---------------------------------------------------------------------------
        if (col.gameObject.tag == "MJ")
        {
			if(elem == "Mns04")
			{
				S1.SetActive(true);
				
				newMnso4.SetActive(true);
				gameObject.SetActive(false);
				i = 1;

            }
			
			else if(elem == "alkali")
			{
				
				S2.SetActive(true);
			
			

				
				newalkali.SetActive(true);
				gameObject.SetActive(false);
				i = 2;
            }

			else if (elem == "sulphuric")
			{

				S3.SetActive(true);

				newsulphuric.SetActive(true);
				gameObject.SetActive(false);
				i = 3;
			}

		}

        // Update is called once per frame
        
    }

    void Update()
    {

    }

}
