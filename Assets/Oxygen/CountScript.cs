using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScript : MonoBehaviour
{
    public GameObject TextCount;
    public TextMesh countText;
    float i = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextCount.SetActive(true);
        i += Time.deltaTime * 1;
        countText.text = Mathf.Round(i).ToString();
        if(i>5)
        {
            TextCount.SetActive(false);
        }

    }
}
