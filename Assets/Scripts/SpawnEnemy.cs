using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EnemyAI
{
    public class SpawnEnemy : MonoBehaviour
    {
         public int numberOfEnemys;
        [SerializeField]protected GameObject enemy;
        [SerializeField]protected  Transform enemyParentGameObject;
        [SerializeField]protected List<GameObject> enemyList = new List<GameObject>();
        // Start is called before the first frame update
    
        void Awake()
        {
            
        }
        void Start()
        {
            
        }
        public void SpawnVaveEnemy(int _numberOfEnemy)
        {
            GameObject _enemy;
            for(int i = 0; i<_numberOfEnemy;i++)
            {
                _enemy = SpawnObject();
                ActiveControl(_enemy,false);
                AssignParent(_enemy,enemyParentGameObject);
                EnemyAddList(_enemy);
            }
            StartCoroutine(EnemyWaiting());
        }
        GameObject SpawnObject()
        {
            var _enemy = Instantiate(enemy);
            return _enemy;
        }
        void ActiveControl(GameObject _enemyControl,bool actived)
        {
            _enemyControl.SetActive(actived);
        }
        void AssignParent(GameObject _enemy, Transform ParentObject)
        {
            _enemy.transform.parent = ParentObject.transform;
        }
        void EnemyAddList(GameObject _enemy)
        {
            enemyList.Add(_enemy);
            
        }
        void EnemyActive()
        {
            
          
        }
        IEnumerator EnemyWaiting()
        {
            Debug.Log("deneme");
            for(int i = 0; i< enemyList.Count; i++)
            {
                 ActiveControl(enemyList[i],true);
                 yield return new WaitForSeconds(2f);
            }

            
        }
    }
}

