using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretSpawner : MonoBehaviour
{
    public Camera camera;
    public LayerMask myLayer;
    public GameObject turretBase;
    public GameObject turretPanel;

    public GameObject turret;
    public GameObject parentTurret;
    // Start is called before the first frame update
    void Start()
    {
        turretPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            MouseRay();
        }
    }

    void MouseRay()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit,100,myLayer))
        {
            turretBase=hit.transform.gameObject;
            turretPanel.SetActive(true);
            Debug.Log("tıklandı");
            
        }
        

    }

    public void ButtonClicked()
    {
        var _turret = Instantiate(turret);
        _turret.transform.position = turretBase.transform.position;
        _turret.transform.parent = parentTurret.transform;
        _turret.transform.position += new Vector3 (0,1.5f,0);  
         turretPanel.SetActive(false);
    }
}
