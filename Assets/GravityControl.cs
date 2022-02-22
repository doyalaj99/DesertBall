using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 3;
        }
        else if (Input.GetKeyUp("space"))
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
        }

    }
}
