using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;


public class panelmove : MonoBehaviour
{
    public ScrollRect ScrollRect;
    public float speed;
    public Transform SelectPannel1;
    public Transform SelectPannel2;
    public Transform SelectPannel3;
    public Transform OptionPannel;
    public float Interpolation;
    public Transform Selecteur1;
    public Transform Selecteur2;
    public Transform Selecteur3;
    public Transform InfoSelecteur;
  
   private Transform _selecteur;
    private Transform selectPanel;
    private GameObject MovePanel;
    private GameObject MovePanel1;
    private GameObject MovePanel2;
    private GameObject MovePanel3;
    private Vector2 RawMovementInput;
    private GameObject _preSeleceted;
    private GameObject SelectedPanel ;
    private GameObject temporalHolder;
    private int _indexSelection = 1;



    public void OnClickTest(InputAction.CallbackContext context)
    {
       
        if (context.started)
        {
            Debug.Log("Test Quoi2");
        }
       
    }


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _selecteur = Selecteur1;
        selectPanel = SelectPannel1;

    }

    private void Update()
    {    
        //      ScrollRect.velocity = new Vector2();
        //Debug.Log(ScrollRect.velocity);
        if (MovePanel != null)
        {
            MovePanel.transform.position =
                Vector3.Lerp(MovePanel.transform.position, SelectPannel1.transform.position, Interpolation);
        }
        if (MovePanel2 != null)
        {
            MovePanel2.transform.position =
                Vector3.Lerp(MovePanel2.transform.position, SelectPannel2.transform.position, Interpolation);
        }
        if (MovePanel3 != null)
        {
            MovePanel3.transform.position =
                Vector3.Lerp(MovePanel3.transform.position, SelectPannel3.transform.position, Interpolation);
        }

        InfoSelecteur.position = Vector3.Lerp(InfoSelecteur.position, selectPanel.position, Interpolation);
        float distMin = 1000;
        
        
        foreach (RectTransform obj in OptionPannel)
        {
            Vector3[] coins = new Vector3[4];
            float smaldist;
            
            obj.GetWorldCorners(coins);
            Vector3 midPos = (coins[0] + coins[1] + coins[2] + coins[3]) / 4;
            smaldist = (midPos - _selecteur.transform.position).magnitude;
            if (distMin >smaldist)
            {
                distMin = smaldist;
                temporalHolder = obj.gameObject;
            }

        }

        if (temporalHolder != _preSeleceted)
        {
            if (_preSeleceted != null)
            {
                _preSeleceted.GetComponent<ActionPannelAnime>().IsPreselected(false);
            }
            temporalHolder.GetComponent<ActionPannelAnime>().IsPreselected(true);
            _preSeleceted = temporalHolder;
           

        }
       
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        RawMovementInput = context.ReadValue<Vector2>();
        ///ebug.Log(RawMovementInput);
        ScrollRect.velocity = RawMovementInput * speed;

    }

    public void OnClick(InputAction.CallbackContext ct)
    {
        if (ct.started)
        {
            Debug.Log("click");

            switch (_indexSelection)
            {
               case 1 :

                   MovePanel = _preSeleceted;
                   MovePanel.transform.SetParent(SelectPannel1);
                   MovePanel.GetComponent<ActionPannelAnime>().IsPreselected(false);
                   _preSeleceted = null;
                   _indexSelection++;

                   selectPanel = SelectPannel2;
                   _selecteur = Selecteur2;
                   break;
               case 2:
                   MovePanel2 = _preSeleceted;
                   MovePanel2.transform.SetParent(SelectPannel2);
                   MovePanel2.GetComponent<ActionPannelAnime>().IsPreselected(false);
                   _preSeleceted = null;
                   _indexSelection++;

                   selectPanel = SelectPannel3;
                   _selecteur = Selecteur3;
                   break;
               case 3:
                   MovePanel3 = _preSeleceted;
                   MovePanel3.transform.SetParent(SelectPannel3);
                   MovePanel3.GetComponent<ActionPannelAnime>().IsPreselected(false);
                   _preSeleceted = null;
                   _indexSelection++;
                   break;
                   
            }
            /*if (selectPanel == SelectPannel1)
            {

                if (MovePanel == null)
                {



                    //MovePanel = OptionPannel.GetChild(0).gameObject;

                    MovePanel = _preSeleceted;
                    MovePanel.transform.SetParent(selectPanel);
                    _preSeleceted.GetComponent<ActionPannelAnime>().IsPreselected(false);
                    _preSeleceted = null;
                    Debug.Log("Selection1");
                    ChangeSelecter();

                }
            }

            if (selectPanel == SelectPannel2)
            {
                if (MovePanel2 == null)
                {


                    //MovePanel = OptionPannel.GetChild(0).gameObject;

                    MovePanel2 = _preSeleceted;
                    MovePanel2.transform.SetParent(selectPanel);
                    _preSeleceted.GetComponent<ActionPannelAnime>().IsPreselected(false);
                    _preSeleceted = null;
                    Debug.Log("Selection2");
                    ChangeSelecter();

                }
            }

            if (selectPanel == SelectPannel3)
            {
                if (MovePanel3 == null)
                {


                    //MovePanel = OptionPannel.GetChild(0).gameObject;

                    MovePanel3 = _preSeleceted;
                    MovePanel3.transform.SetParent(selectPanel);
                    _preSeleceted.GetComponent<ActionPannelAnime>().IsPreselected(false);
                    _preSeleceted = null;
                    Debug.Log("Selection3");
                    ChangeSelecter();

                }
            }*/
        }

    }

    private void ChangeSelecter()
    {
        if (selectPanel == SelectPannel1)
        {
            selectPanel = SelectPannel2;
            _selecteur = Selecteur2;
            return;
        }

        if (selectPanel == Selecteur2)
        {
            selectPanel = SelectPannel3;
            _selecteur = Selecteur3;
        }
        
    }
}
