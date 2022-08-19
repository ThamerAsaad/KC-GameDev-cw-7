using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Enemy;

    public GameObject Coin;

    
    public float delay;

    public Transform leftpos;
    public Transform rightpos;
    public Transform midpos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy" , 0f , delay);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    void SpawnEnemy()
    {
        int Random1 = Random.Range(1, 4);
        if(Random1 == 1 || Random1 == 2 )
        {
            int randnum = Random.Range(1, 4);
            if (randnum == 1)
            {
                Instantiate(Enemy, leftpos);
            }
            else if (randnum == 2)
            {
                Instantiate(Enemy, midpos);
            }
            else
            {
                Instantiate(Enemy, rightpos);
            }
            
        }
        else
        {
            int randnum = Random.Range(1, 4);
            if (randnum == 1)
            {
                Instantiate(Coin, leftpos);
            }
            else if (randnum == 2)
            {
                Instantiate(Coin, midpos);
            }
            else
            {
                Instantiate(Coin, rightpos);
            }
        }
        


    }







}
