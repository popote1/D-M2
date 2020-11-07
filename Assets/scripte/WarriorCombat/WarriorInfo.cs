using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorInfo : IComparable<WarriorInfo>
{
    public string Name;
    public float HP;
    public float For;
    public float Agi;
    public int Vit;
    public float End;
    public float Arm;
    public float CurrentHp;
    public List<CombatAction> CombatActions;
    public int TimeLineAdvence;
    public UIWarriorHolder UIWarriorHolder;
    public UIWarriorTimeLine UIWarriorTimeLine;
    public CombatManager CombatManager;
    public WarriorInfo(string name , float hp , float _for , float agi , int vit , float end , float arm , List<CombatAction> combatActions)
    {
        Name = name;
        HP = hp;
        For = _for;
        Agi = agi;
        End = end;
        Vit = vit;
        Arm = arm;
        CurrentHp = HP;
        
        CombatActions = combatActions;
    }
    public int CompareTo(WarriorInfo comparePart)
    {
        // A null value means that this object is greater.
        if (comparePart == null)
            return 1;

        else
            return this.TimeLineAdvence.CompareTo(comparePart.TimeLineAdvence);
    }

    public void TakeCombatDamage(float damage)
    {
        CurrentHp -= damage;
        UIWarriorHolder.TakeDamage(CurrentHp);
        if (CurrentHp <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        CombatManager.warriorDie(this);
    }
}
