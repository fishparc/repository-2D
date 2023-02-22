using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript2 : MonoBehaviour
{
    public Text textScore;
    public static int Score;
    public float speed = 10;
    public GameObject explosion;
    public GameObject heart;
    public GameObject heart1;
    public GameObject heart2;
    int HeartNum = 3;
    // Start is called before the first frame update
    void Start()
    {
        Score =0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "wall4")
            Destroy(this.gameObject);
        if (collision.name == "bulletpref(Clone)") 
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
                Instantiate(explosion, transform.position, transform.rotation);
            score.Score++;

            }
        if (collision.name == "public GameObject heart")
        {
            HeartNum--;
            if (HeartNum == 2)
                heart2.SetActive(false);
            else if (HeartNum == 1)
                heart1.SetActive(false);
            else if (HeartNum == 0)
                heart.SetActive(false);
        }
     }
 }