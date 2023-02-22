using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject heart;
    public GameObject heart1;
    public GameObject heart2;
    int HeartNum = 3;
    public float speed = 10;
    public GameObject Bullet;
    public Text failed;
    // Start is called before the first frame update
    void Start()
    {
        failed.gameObject.SetActive(false) ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0, speed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(0, -speed * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(Bullet, transform.position+new Vector3(0, 1.5f, 0), transform.rotation);
        if (Input.GetKeyDown(KeyCode.R))
           { SceneManager.LoadScene(SceneManager.GetActiveScene().name);
             Time.timeScale = 1f;
           }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(other.name=="Chips(Clone)")
        HeartNum--;
               if (HeartNum == 2)
                  heart2.SetActive(false);
              else if (HeartNum == 1)
                  heart1.SetActive(false);
              else if (HeartNum == 0)
                 { heart.SetActive(false);
                 failed.gameObject.SetActive(true);
                 Time.timeScale = 0f;
                 }
    }
}
