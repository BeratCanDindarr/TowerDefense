using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewTurret", menuName ="towerDefense/Turret")]
public class TurretDamageSystem : ScriptableObject
{
    public int turretDamage ;
    public float turretFireRate ;
    public GameObject Turret;
    
    
}
