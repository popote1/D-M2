using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CombatAction :ScriptableObject
{
    public string Name;
    public virtual void MakeAction(WarriorInfo attacker, WarriorInfo target)
    {
        Debug.Log(" faite l'acrion dans la class mere");
    }
}
