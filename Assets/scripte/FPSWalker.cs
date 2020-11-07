using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPSWalker : MonoBehaviour
{
    public float Speed;
    public float RotationSpeeed;
    private CharacterController _cc;
    private Vector3 _mouvement;
    
    
    void Start()
    {
        _cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Update()
    {
        _cc.Move((transform.forward*_mouvement.y+transform.right*_mouvement.x) * Speed * Time.deltaTime);
        
    }

    //mouvement du personage et control de la camera
    void FixedUpdate()
    {
       
      //  Vector3 mouvement = transform.forward * Input.GetAxis("Vertical")+ transform.right * Input.GetAxis("Horizontal");
        //_cc.Move(mouvement*Speed);
        //transform.Rotate(Vector3.up*Input.GetAxisRaw("Mouse X")*RotationSpeeed);
    }

    public void Walk(InputAction.CallbackContext ctx)
    {
       
            Debug.Log("move");
            _mouvement = ctx.ReadValue<Vector2>();
            //new Vector3(ctx.ReadValue<Vector2>().x,0,ctx.ReadValue<Vector2>().y);
            //transform.forward * Input.GetAxis("Vertical")+ transform.right * Input.GetAxis("Horizontal");


    }

    public void ClickTest(InputAction.CallbackContext ctx)
    {
        Debug.Log("Click");
    }

    public void LookCam(InputAction.CallbackContext ctx)
    {
        Vector2 RawMovementInput = ctx.ReadValue<Vector2>();
        transform.Rotate(Vector3.up*RawMovementInput.x*RotationSpeeed);
    }
}
