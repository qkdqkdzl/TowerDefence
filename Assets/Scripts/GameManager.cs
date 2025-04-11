using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject world;
    public Enemy enemyPrefab;
    public Enemy Enemy;
    public Turret turret;
    public Transform _battlField;

    void Start()
    {
        Initialize();
        
    }

    void Initialize()
    {
        // 0,1,2,3,4
        for (int i = 0; i < 10; i++)
        {
            //Tooo;
            int xPds = UnityEngine.Random.Range(2, 10);
            int zPds = UnityEngine.Random.Range(2, 10);

            Vector3 pos = new Vector3(xPds, zPds);

            Instantiate(enemyPrefab, pos, Quaternion.identity); //.transform.SetParent(world);
            Instantiate(enemyPrefab, pos, Quaternion.identity).transform.SetParent(_battlField);
        }


    }

}
