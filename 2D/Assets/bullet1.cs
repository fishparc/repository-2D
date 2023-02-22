using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.1f, 0);

    }
void OnTriggerEnter2D(Collider2D collision)
     {   
     if (collision.name == "Top")        
     Destroy(this.gameObject);
     }

}

