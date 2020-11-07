using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class   GeneralCombatHelper 
{
 public static int  HitCalulation(CASimpleAttack attackWaepon,WarriorInfo attaker, WarriorInfo target)
 {
  int dice = Random.Range(2, 12);
  if (dice == 2)
  {
   Debug.Log("Echec Critique avec un "+dice);
   return 0;
  }else if (dice == 12)
  {
   Debug.Log("Reussit Critique avec un "+dice);
   return 3;
  }

  if (attackWaepon.Pressision + attaker.Agi + dice < target.Agi * 2)
  {
   Debug.Log("l'attaque rate avec un jet de "+dice);
   return 1;
  }else
   Debug.Log("L'attauqe touche avec un jet de "+dice);
  return 2;
 }

 public static float DamageCalculation(CASimpleAttack attackWaepon, WarriorInfo attaker, WarriorInfo target,bool isCrit)
 {
  int dice = Random.Range(2, 12);
  Debug.Log("Inflige" + dice + " de dégat par les dées");
  float damage = attackWaepon.Damage+attaker.For+dice;
  if (isCrit) damage = damage * 2;
  return Mathf.Clamp(damage - Mathf.Clamp(target.Arm - attackWaepon.Peneration,0,target.Arm),0,damage);
 }

 public static int TimeCalulation(CASimpleAttack attckWeapon, WarriorInfo attacker, bool isCrit)
 {
  if (isCrit) return 100 - Mathf.RoundToInt((attckWeapon.vitesse + attacker.Vit) * 2);
  return 100 - Mathf.RoundToInt(attckWeapon.vitesse + attacker.Vit);
 }
 

}
