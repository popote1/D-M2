using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIWarriorTimeLine : MonoBehaviour
{
   public float Value;
   public TMP_Text TxtName;
   public TMP_Text TxtValue;

   public WarriorInfo WarriorInfo;
   public void SetdeflaultValue( WarriorInfo warriorInfo)
   {
      WarriorInfo = warriorInfo;
      TxtName.text = WarriorInfo.Name;
      Value = WarriorInfo.TimeLineAdvence;
      TxtValue.text = Value + "";
   }
}
