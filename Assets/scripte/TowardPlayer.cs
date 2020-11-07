using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowardPlayer : MonoBehaviour
{
    public Transform Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = transform.position - Player.position;
    }
}
