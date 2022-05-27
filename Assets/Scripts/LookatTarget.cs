using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatTarget : MonoBehaviour
{
    public GameObject target;
    bool isTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("deneme");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isTriggered)
            transform.LookAt(target.transform);
    }
    void OnTriggerEnter(Collider other)
    {
        if(!isTriggered)
        {
            target = other.gameObject;
            isTriggered = true;
        }
    }
     void OnTriggerExit(Collider other)
    {
        if(isTriggered)
        {
            target= null;
            isTriggered = false;
        }
    }
}
