using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item",menuName = "ScriptableObjects/Item")]
public class SOItem : ScriptableObject
{
    public enum itemType
    {
        Arme,Armur,Compsomable,QuestObject
    }
    public itemType ItemType;
    public enum corpPos
    {
        tete,torse, gant , jamble , main
    }

    public corpPos CorpPos;

    [Header("Bonus Stats")]
    public int BonusForce;
    public int BonusDex;
    public int BonusCon;
    public int BonusInt;

    [Header("Stat d'arme")] 
    public typeArme TypeArme;
    public enum typeArme
    {
        tranchant, Contendant,magique
    }
    public int Degas;
    public int PenetrationDarmure;

    [Header("Stat Armure")] 
    public int BonusArmure;
}
