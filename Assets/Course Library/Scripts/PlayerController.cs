using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float speed;

    float maxXLimits;
    float minXLimits;

    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        maxXLimits = 10;
        minXLimits = -10;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < minXLimits)
        {
            transform.position = new Vector3(minXLimits, transform.position.y, transform.position.z);
        } else if (transform.position.x > maxXLimits)
        {
            transform.position = new Vector3(maxXLimits, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
