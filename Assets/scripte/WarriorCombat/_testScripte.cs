using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _testScripte : MonoBehaviour
{
    public List<ObjectATrier> Objs;
    void Start()
    {
        Objs.Sort();

        foreach (ObjectATrier obj in Objs)
        {
            Debug.Log(obj.Name+ "  de valeur "+obj.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[Serializable]
public class ObjectATrier :IComparable<ObjectATrier>
{
    public string Name;
    public float Value;
    public int objId { get; set; }
    public int CompareTo(ObjectATrier comparePart)
    {
        // A null value means that this object is greater.
        if (comparePart == null)
            return 1;

        else
            return this.Value.CompareTo(comparePart.Value);
    }
}
