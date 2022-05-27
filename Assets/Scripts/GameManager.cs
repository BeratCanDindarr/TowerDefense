using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyAI
{
    
    public class GameManager : MonoBehaviour
    {
         public int numberOfEnemys;
        public GameObject spawnEnemy;
        void Start()
        {
           var _spawnEnemy = spawnEnemy.GetComponent<SpawnEnemy>();
           _spawnEnemy.SpawnVaveEnemy(numberOfEnemys);
           Debug.Log("deneme");
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

}