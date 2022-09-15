using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddChild : MonoBehaviour
{
    public GameObject ChildPlayerOneName;
    public Transform parent;

    public void AddChildPrefer()
    {
        // ChildPlayerOneName.transform.SetParent (this.transform);
        ChildPlayerOneName.transform.SetParent(transform);
    }
    
}
