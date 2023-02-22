using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Text textScore;
    public static int Score;
    // Start is called before the first frame update
    void Start()
    {
        Score =0;
    }

    // Update is called once per frame
    void Update()
    {
         textScore.text = "Score:" + Score.ToString();

    }
}
