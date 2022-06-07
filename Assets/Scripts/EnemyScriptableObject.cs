using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(menuName = "towerDefense/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
        public List<GameObject> enemys;
        public bool damageControl = false;
}

