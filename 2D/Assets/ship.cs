using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
         float speed =0.05f;
         
        if(Input.GetKey("down"))

    {
            transform.Translate(0, -speed, 0);


        }
        if (Input.GetKey("up"))
    
    {
            transform.Translate(0, speed, 0);
    }
            if (Input.GetKey("left"))

    {
                transform.Translate(-speed,0, 0);

            }
            if (Input.GetKey("right"))
        
    {
                transform.Translate( speed,0, 0);

            }
    }

    }

