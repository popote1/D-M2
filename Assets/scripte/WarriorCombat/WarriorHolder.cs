using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorHolder : MonoBehaviour
{
    public string Name;
    public float HP;
    public float For;
    public float Agi;
    public int Vit;
    public float End;
    public float Arm;
    public List<CombatAction> CombatActions;

    public WarriorInfo Warrior;
    
    void Start()
    {
        Warrior = new WarriorInfo(Name , HP , For, Agi , Vit , End, Arm,CombatActions);
    }

   
}
