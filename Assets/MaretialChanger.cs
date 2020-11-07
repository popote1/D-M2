using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class MaretialChanger : MonoBehaviour
{
    public Material nNwMat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nNwMat != null)
        {
            ChangeMat();
        }
    }
    
    public void ChangeMat()
    {
        foreach (Transform obj in transform)
        {
            obj.GetComponent<MeshRenderer>().material = nNwMat;
        }
    }
}
