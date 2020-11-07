using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CombatManager : MonoBehaviour
{
    public List<WarriorHolder> WarriorHolders;


    [Header("UI")] public GameObject ActorsPanel;
    public GameObject ActionPanel;
    public GameObject TimeLinePanel;

    [Header("Prefabs")] public GameObject ActionButton;
    public GameObject ActorPersonalPanel;
    public GameObject TimeLineActorPanel;
    public GameObject OptionPannl;
    public GameObject OptionButton;


    private List<WarriorInfo> Warriors = new List<WarriorInfo>();
    private WarriorInfo _activeWarrior;

    private int _stat = 0;

    void Start()
    {
        foreach (var warriorHolder in WarriorHolders)
        {
            WarriorInfo warrior = warriorHolder.Warrior;
            warrior.TimeLineAdvence = 100-warrior.Vit;
            GameObject actorPanl = Instantiate(ActorPersonalPanel, ActorsPanel.transform);
            actorPanl.GetComponent<UIWarriorHolder>().setdefaultvalue(warrior.Name, warrior.HP, warrior.HP);
            warrior.UIWarriorHolder = actorPanl.GetComponent<UIWarriorHolder>();
            warrior.CombatManager = this;
            Warriors.Add(warrior);
        }

        ResteTimeLine();
        _stat = 1;
    }

    void Update()
    {
        if (_stat == 1)
        {
            _activeWarrior = SelectActiveWarrior();
            setActions();
        }

        if (_stat == 4)
        {
           
            
            _stat = 5;

        }

        if (_stat == 5)
        {
            ResetTargetChoices();
            ResetAction();
            ResteTimeLine();
            Invoke("PassTime", 0.2f); 
            Invoke("ResteTimeLine",0.3f);
            _stat = 1; 
        }
    }

    private void Stat5()
    {
        _stat = 5;
    }

    private void ResteTimeLine()
    {
        Warriors.Sort();
        foreach (Transform obj in TimeLinePanel.transform)
        {
            Destroy(obj.gameObject, 0.01f);
        }

        foreach (var war in Warriors)
        {
            GameObject obj = Instantiate(TimeLineActorPanel, TimeLinePanel.transform);
            obj.GetComponent<UIWarriorTimeLine>().SetdeflaultValue(war);
            war.UIWarriorTimeLine = obj.GetComponent<UIWarriorTimeLine>();
        }
    }

    private WarriorInfo SelectActiveWarrior()
    {
        return TimeLinePanel.transform.GetChild(0).GetComponent<UIWarriorTimeLine>().WarriorInfo;
    }

    private void setActions()
    {
        foreach (var combat in _activeWarrior.CombatActions)
        {
            GameObject bp = Instantiate(ActionButton, ActionPanel.transform);
            bp.GetComponentInChildren<TMP_Text>().text = combat.Name;
            bp.GetComponent<Button>().onClick.AddListener(delegate
            {
                setTargetChoice(combat);
            });
        }
        ActionPanel.transform.GetChild(0).GetComponent<Button>().Select();

        _stat = 2;
    }

    public void setTargetChoice(CombatAction caSimpleAttack)
    {
        List<WarriorInfo> targer = new List<WarriorInfo>();
        OptionPannl.SetActive(true);
        foreach (var war in Warriors)
        {
            if (war != _activeWarrior)
            {
                targer.Add(war);
            }
        }
        foreach (var war in targer)
        {
            GameObject bp = Instantiate(OptionButton, OptionPannl.transform);
            bp.GetComponentInChildren<TMP_Text>().text = war.Name;
            bp.GetComponent<Button>().onClick.AddListener(delegate
            {
                Debug.Log("Attaque de "+war.Name);
                caSimpleAttack.MakeAction(_activeWarrior,war);
                _stat = 4;
            });
            OptionPannl.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,OptionPannl.GetComponent<RectTransform>().rect.height+30);
            if (bp.transform.GetSiblingIndex() != 0)
            {
                Navigation nav = bp.GetComponent<Button>().navigation;
                Navigation navT = OptionPannl.transform.GetChild(bp.transform.GetSiblingIndex() - 1)
                    .GetComponent<Button>().navigation;
                nav.selectOnUp = OptionPannl.transform.GetChild(bp.transform.GetSiblingIndex() - 1)
                    .GetComponent<Button>();
                navT.selectOnDown = bp.GetComponent<Button>();
                OptionPannl.transform.GetChild(bp.transform.GetSiblingIndex() - 1)
                    .GetComponent<Button>().navigation = navT;
                bp.GetComponent<Button>().navigation = nav;
            }
        }

        GameObject bpr = Instantiate(OptionButton, OptionPannl.transform);
        bpr.GetComponentInChildren<TMP_Text>().text = "Retour";
        bpr.GetComponent<Button>().onClick.AddListener(delegate
        {
            Debug.Log("appuis sur retour");
            ActionPanel.transform.GetChild(0).GetComponent<Button>().Select();
            ResetTargetChoices();
        });
        Navigation navr = bpr.GetComponent<Button>().navigation;
        Navigation navTr = OptionPannl.transform.GetChild(bpr.transform.GetSiblingIndex() - 1)
            .GetComponent<Button>().navigation;
        navr.selectOnUp = OptionPannl.transform.GetChild(bpr.transform.GetSiblingIndex() - 1)
            .GetComponent<Button>();
        navTr.selectOnDown = bpr.GetComponent<Button>();
        OptionPannl.transform.GetChild(bpr.transform.GetSiblingIndex() - 1)
            .GetComponent<Button>().navigation = navTr;
        bpr.GetComponent<Button>().navigation = navr;
        OptionPannl.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,OptionPannl.GetComponent<RectTransform>().rect.height+30);
        OptionPannl.transform.GetChild(0).GetComponent<Button>().Select();
        _stat = 3;
    }

    public void ResetTargetChoices()
    {
        foreach (Transform choice in OptionPannl.transform)
        {
            Destroy(choice.gameObject,0.01f);
        }

        OptionPannl.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 10);
        OptionPannl.SetActive(false);
    }

    private void ResetAction()
    {
        foreach (Transform obj in ActionPanel.transform)
        {
            Destroy(obj.gameObject,0.01f);
        }
    }

    private void PassTime()
    {
        Debug.Log(
            "Opération dans la method PassTime ----------------------------------------------------------------------------------------------------------------------------------");
        int time = TimeLinePanel.transform.GetChild(0).GetComponent<UIWarriorTimeLine>().WarriorInfo.TimeLineAdvence;
        Debug.Log("Sur le passage du temps "+time+" est passer pour "+TimeLinePanel.transform.GetChild(0).GetComponent<UIWarriorTimeLine>().WarriorInfo.Name);
        foreach (Transform obj in TimeLinePanel.transform)
        {
            //obj.GetComponent<UIWarriorTimeLine>().WarriorInfo.TimeLineAdvence -= time;
            Debug.Log( obj.GetComponent<UIWarriorTimeLine>().WarriorInfo.Name+ " a une valeur de temps de "+obj.GetComponent<UIWarriorTimeLine>().WarriorInfo.TimeLineAdvence+" qui va etre soustrète par "+time);
            int newTime = obj.GetComponent<UIWarriorTimeLine>().WarriorInfo.TimeLineAdvence - time;
            Debug.Log(" le nouveau time est de " + newTime);
            obj.GetComponent<UIWarriorTimeLine>().WarriorInfo.TimeLineAdvence = newTime;
        }
        Debug.Log( "fin-----------------------------------------------------------------------------------------------------------------------------------------------");
    }

    public void warriorDie(WarriorInfo wa)
    {
        Warriors.Remove(wa);
        Destroy(wa.UIWarriorHolder.gameObject);
        Destroy(wa.UIWarriorTimeLine.gameObject);
    }
    
    
}

    
