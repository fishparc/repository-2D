using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, -0.05f, 0);

    }
void OnTriggerEnter2D(Collider2D collision)
{
     if (collision.name == "Bottom")
    {
         Destroy(this);
    }
}


}