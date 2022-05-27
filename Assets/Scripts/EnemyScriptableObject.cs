using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(menuName = "towerDefense/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{

        public int numberOfEnemys;
        public GameObject enemy;
        public  Transform enemyParentGameObject;
        public List<GameObject> enemyList = new List<GameObject>();
}

