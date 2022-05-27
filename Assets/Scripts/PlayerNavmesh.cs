using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavmesh : MonoBehaviour
{
    [SerializeField] Transform movePositionTransform;
    private NavMeshAgent navMeshAgent;
    private void Awake() 
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }
    void Start()
    {
        navMeshAgent.destination = movePositionTransform.position;
    }
    private void Update() {
        
    }
    
  
}
