
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Turret
{

    public class PlayerNavmesh : MonoBehaviour
    {
        [SerializeField] Transform movePositionTransform;
        private NavMeshAgent navMeshAgent;
        public float health;
        float _damage;
        
        private void Awake() 
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            
        }
        void Start()
        {
            navMeshAgent.destination = movePositionTransform.position;
            
        }
        private void Update() 
        {
            
        }
        public void Damaged(float damage)
        {
            _damage = damage;
            health -= _damage;
        }
        public void Deneme()
        {
            Destroy(gameObject);
        }
        
        
    
    }
}
