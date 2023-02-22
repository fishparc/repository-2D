using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    public GameObject Monster;
    public float timer = 0;
    public float peroid = 0.5f;
    float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer> peroid)
        {
            timer = 0;
            x = Random.Range(-7, 7);
            Instantiate(Monster, new Vector3(x, 10, 0), transform.rotation );
        }
    }
}
