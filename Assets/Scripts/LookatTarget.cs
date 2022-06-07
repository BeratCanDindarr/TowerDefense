using System.Diagnostics;
using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Turret
{

    public class LookatTarget : MonoBehaviour
    {
    
        public List<GameObject> enemys;
        
        bool isNull = true;
        RaycastHit hit;
        public float damage;
        float distance = 10f;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(!isNull) 
            {
                LookGameObject();
                Ray();            
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
            var fwd =transform.TransformDirection (Vector3.forward); 
            if(Physics.Raycast(transform.position,fwd,out hit,distance) && hit.transform.tag == "Enemy")
            {
                var enemy = hit.transform.gameObject.GetComponent<PlayerNavmesh>();
                if(enemy.health < 0)
                {
                    enemy.Deneme();
                    enemys.Remove(enemy.gameObject);
                    isNull = true;
                }
                enemy.Damaged(damage*Time.deltaTime);
            }
        }
        void Destroy(GameObject destroye)
        {
            enemys.Remove(destroye);
            Destroy(destroye);
        }
    }
}
