using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatTarget : MonoBehaviour
{
   
    public List<GameObject> enemys;
    bool isNull = true;
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
        }
    }
    void OnTriggerEnter(Collider other)
    {
        isNull = false;
        enemys.Add(other.gameObject);
       
    }
     void OnTriggerExit(Collider other)
    {
        enemys.Remove(other.gameObject);    
        if(enemys.Count == 0)
        {
            isNull = true;
        }
    }
    void LookGameObject()
    {
        transform.LookAt(enemys[0].transform);
    }
}
