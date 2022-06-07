
using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Turret
{

    public class LookatTarget : MonoBehaviour
    {
    
        public List<GameObject> enemys;
        public LayerMask enemyLayers;
        
        bool isNull = true;
        RaycastHit hit;
        public float damage;
        float distance = 10f;
        public float timeLeft;
        float _timeLeft;
        // Start is called before the first frame update
        void Start()
        {
            _timeLeft = timeLeft;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(!isNull) 
            {
                LookGameObject();               
                _timeLeft -= Time.deltaTime;
                if(_timeLeft < 0)
                {
                    Debug.Log("ateş edildi");
                    Ray();            
                    _timeLeft = timeLeft;
                }
            }
        }
        void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Enemy")
            {
                isNull = false;
                enemys.Add(other.gameObject);

            }
        
        }
        void OnTriggerExit(Collider other)
        {
            if(other.tag == "Enemy")
            {
                enemys.Remove(other.gameObject);   
                if(enemys.Count == 0)
                {
                    isNull = true;
                }

            }
        }
        void LookGameObject()
        {
            if(enemys[0] == null)
            {
                enemys.RemoveAt(0);
            }
            if(enemys.Count == 0)
            {
                isNull = true;
            }
            else
                transform.LookAt(enemys[0].transform);
        }
        void Ray()
        {
            Debug.DrawRay(transform.position, transform.forward, Color.red);
            var fwd =transform.TransformDirection (Vector3.forward); 
            if(Physics.Raycast(transform.position,fwd,out hit,distance,enemyLayers) && hit.transform.tag == "Enemy")
            {
                var enemy = hit.transform.gameObject.GetComponent<PlayerNavmesh>();
                if(enemy.health < 0)
                {
                    enemy.Deneme();
                    enemys.Remove(enemy.gameObject);
                    isNull = true;
                }
                enemy.Damaged(damage);
            }
        }
        void Destroy(GameObject destroye)
        {
            enemys.Remove(destroye);
            Destroy(destroye);
        }
    }
}
