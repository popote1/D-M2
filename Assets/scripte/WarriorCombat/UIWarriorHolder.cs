using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  TMPro;

public class UIWarriorHolder : MonoBehaviour
{
    public Slider SliHp;
    public TMP_Text TxtName;
    public TMP_Text TxtHp;
   
    
    
    private float _maxHp;


    public void setdefaultvalue(string name, float maxHp, float currentHp)
    {
        _maxHp = maxHp;
        TxtName.text = name;
        TxtHp.text = currentHp + "/" + _maxHp;
        SliHp.value = currentHp / _maxHp;
    }

    public void TakeDamage(float currentHp)
    {
        TxtHp.text = currentHp + "/" + _maxHp;
        SliHp.value = currentHp / _maxHp;
    }
}
