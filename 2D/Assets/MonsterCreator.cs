using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCreator : MonoBehaviour
{
    public GameObject Monster;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateMonster", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void GenerateMonster()
    {
        int MonsterNum;
        
        MonsterNum = Random.Range(0, 3);

        for (int i = 0; i < MonsterNum; i++)
        {
           
            float x;
          
            x = Random.Range(-6, 6);
    
            Instantiate(Monster, new Vector3(x, 2.8f, 0), Quaternion.identity);
        }

}
}
