using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
[CreateAssetMenu(fileName = "CombatAction", menuName = "SO/CombatAction/CoupDeBouclier")]
public class CACoupDeBouclier :CASimpleAttack
{
   
    public override void MakeAction(WarriorInfo attacker, WarriorInfo target)
    {
        int hitIndex =GeneralCombatHelper.HitCalulation(this, attacker, target);
        if (hitIndex == 2)
        {
            float damage = GeneralCombatHelper.DamageCalculation(this, attacker, target, false);
            int time =GeneralCombatHelper.TimeCalulation(this, attacker, false);
            attacker.TimeLineAdvence = time;
            Debug.Log("le nouveaux temps de " + attacker.Name + " est de " + time);
            Debug.Log("Inflige "+damage+" damage");
            target.TakeCombatDamage(damage);
        }

        if (hitIndex == 3)
        {
            float damage = GeneralCombatHelper.DamageCalculation(this, attacker, target, true);
            int time =GeneralCombatHelper.TimeCalulation(this, attacker, false);
            attacker.TimeLineAdvence = time;
            Debug.Log("le nouveaux temps de " + attacker.Name + " est de " + time);
            Debug.Log("Inflige "+damage+" damage en critique");
            target.TakeCombatDamage(damage);
        }

        if (hitIndex==1)
        {
            int time =GeneralCombatHelper.TimeCalulation(this, attacker, false);
            attacker.TimeLineAdvence = time;
            Debug.Log("le nouveaux temps de " + attacker.Name + " est de " + time);
        }
        if (hitIndex==0)
        {
            int time =GeneralCombatHelper.TimeCalulation(this, attacker, true);
            attacker.TimeLineAdvence = time;
            Debug.Log("le nouveaux temps de " + attacker.Name + " est de " + time + "echeck Critique");
        }
        
    }
}
