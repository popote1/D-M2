using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPannelAnime : MonoBehaviour
{
   public void IsPreselected(bool istrue)
   {
      if (istrue)
      {
          LeanTween.scale(this.gameObject, new Vector3(1.3f, 1.3f, 1.3f), 0.1f);
      }
      else
      {
          LeanTween.scale(this.gameObject, new Vector3(1, 1, 1), 0.1f);
      }
   }
}
