using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class inventory : MonoBehaviour
{

    public GameObject bouton;
    public Scrollbar Scrollbar;
    public Button ButtonGauche;
    public GameObject Panel;

    [Header("Default Stats")] 
    public int DefForce;
    public int DefDex;
    public int DefCon;
    public int DefInt;
    public int DefArm;
    public List<SOItem> Inventaire;
    
    [Header("Stats")] 
    public TMP_Text UIFor;
    public TMP_Text UIDex;
    public TMP_Text UICon;
    public TMP_Text UIInt;
    public TMP_Text UIArm;
    [Header("UIEquipement")]
    public Button BpTete;
    public Button BpMains;
    public Button BpTorce;
    public Button BpJambes;
    public Button BpMainDroite;
    public Button BpMainGauche;

    private int _for;
    private int _dex;
    private int _con;
    private int _int;
    private int _arm;
    private SOItem _sotete;
    private SOItem _sotorce;
    private SOItem _soMains;
    private SOItem _soJambes;
    private SOItem _soMainDoite;
    private SOItem _soMainGauche;

    private void Start()
    {
        ButtonGauche.Select();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _for = DefForce;
        _dex = DefDex;
        _con = DefCon;
        _int = DefInt;
        _arm = DefArm;
        ShowStats();
        foreach (var item in Inventaire)
        {
           // int index = Random.Range(0, Inventaire.Count);
            InstanciateIeam(item);
        }
    }

    public void InstanciateIeam(SOItem item)
    {
        GameObject bpo = Instantiate(bouton, Panel.transform);
        Button bp = bpo.GetComponent<Button>();
        bpo.GetComponent<IteamHolder>().Item = item;
        bp.GetComponentInChildren<TMP_Text>().text = item.name;
        bp.onClick.AddListener(delegate { EquipeItem(item,bp.gameObject); });
        Navigation nav = bp.navigation;
        nav.mode = Navigation.Mode.Explicit;
        nav.selectOnLeft = ButtonGauche;
        nav.selectOnRight = Scrollbar;
        if (ButtonGauche.navigation.selectOnRight == null)
        {
            Navigation navG =ButtonGauche.navigation;
            navG.selectOnRight = bp;
            ButtonGauche.navigation = navG;
        }

        if (Scrollbar.navigation.selectOnLeft == null)
        {
            Navigation navD = Scrollbar.navigation;
            navD.selectOnLeft = bp;
            Scrollbar.navigation = navD;
        }
        if (bpo.transform.GetSiblingIndex() - 1 >= 0)
        {
            GameObject topItem = Panel.transform.GetChild(bpo.transform.GetSiblingIndex() - 1).gameObject;
            nav.selectOnUp = topItem.GetComponent<Button>();
            Navigation navT =topItem.GetComponent<Button>().navigation;
            navT.selectOnDown = bp;
            topItem.GetComponent<Button>().navigation = navT;
        }

        /* if (Panel.transform.GetSiblingIndex() + 1 <= Panel.transform.childCount)
        {
            GameObject botItem = Panel.transform.GetChild(Panel.transform.GetSiblingIndex() + 1).gameObject;
        }*/
        bp.navigation = nav;
    }

    public void EquipeItem(SOItem item,GameObject bp)
    {
        GameObject bpEquipement = new GameObject();
        if (item.ItemType == SOItem.itemType.Armur)
        {
            switch (item.CorpPos)
            {
                case SOItem.corpPos.tete:
                    bpEquipement = BpTete.gameObject;
                    break;
                case SOItem.corpPos.torse:
                    bpEquipement = BpTorce.gameObject;
                    break;
                case SOItem.corpPos.main:
                    bpEquipement = BpMains.gameObject;
                    break;
                case SOItem.corpPos.jamble:
                    bpEquipement = BpJambes.gameObject;
                    break;
            }
        }else if (item.ItemType == SOItem.itemType.Arme)
        {
            bpEquipement = BpMainDroite.gameObject;
        }

        if (bpEquipement.GetComponent<IteamHolder>().Item != null)
        {
            DesequipeItem(bpEquipement.GetComponent<Button>());
        }
        bpEquipement.GetComponent<IteamHolder>().Item = item;
        bpEquipement.GetComponentInChildren<TMP_Text>().text = item.name;
        _arm += item.BonusArmure;
        _for += item.BonusForce;
        _dex += item.BonusDex;
        _con += item.BonusCon;
        _int += item.BonusInt;
        ShowStats();
        RemoveItemFromInventory(bp);
        bpEquipement.GetComponent<Button>().Select();
    }

    public void DesequipeItem(Button bp)
    {
        bp.gameObject.GetComponentInChildren<TMP_Text>().text = "";
        SOItem iteam = bp.GetComponent<IteamHolder>().Item;
        _arm -= iteam.BonusArmure;
        _for -= iteam.BonusForce;
        _dex -= iteam.BonusDex;
        _con -= iteam.BonusCon;
        _int -= iteam.BonusInt;
        ShowStats();
        InstanciateIeam(iteam);
    }

    private void ShowStats()
    {
        UIFor.text = _for + "";
        UIDex.text = _dex + "";
        UICon.text = _con + "";
        UIInt.text = _int + "";
        UIArm.text = _arm + "";
    }

    private void RemoveItemFromInventory(GameObject bpo)
    {
        GameObject topItem=new GameObject();
        GameObject botItem=new GameObject();
        topItem = null;
        botItem = null;
        if (bpo.transform.GetSiblingIndex() - 1 >= 0)
        {
            Debug.Log(bpo.transform.GetSiblingIndex()-1);
             topItem = Panel.transform.GetChild(bpo.transform.GetSiblingIndex() - 1).gameObject;
        }
        if (bpo.transform.GetSiblingIndex() + 1 <= Panel.transform.childCount)
        {
            botItem = Panel.transform.GetChild(bpo.transform.GetSiblingIndex() + 1).gameObject;
        }

        
        if (topItem != null && botItem != null)
        {
            Navigation navT=topItem.GetComponent<Button>().navigation;
            Navigation navB = botItem.GetComponent<Button>().navigation;
            navT.selectOnDown = botItem.GetComponent<Button>();
            navB.selectOnUp = topItem.GetComponent<Button>();
            topItem.GetComponent<Button>().navigation = navT;
            botItem.GetComponent<Button>().navigation = navB;
        }

        if (topItem == null)
        {
            Navigation navB = botItem.GetComponent<Button>().navigation;
            Navigation navD = Scrollbar.navigation;
            Navigation navG = ButtonGauche.navigation;
            navD.selectOnLeft = botItem.GetComponent<Button>();
            navB.selectOnRight = Scrollbar;
            navG.selectOnRight = botItem.GetComponent<Button>();
            navB.selectOnLeft = ButtonGauche;
            botItem.GetComponent<Button>().navigation = navB;
            Scrollbar.navigation = navD;
            ButtonGauche.navigation = navG;

        }
        Destroy(bpo);
    }
}
