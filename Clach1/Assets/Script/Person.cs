using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public string Name = "Edgar Luna";
    public int id = 123456789;

    public virtual void GetInfo()
    {
        Debug.Log("Name: " + Name);
        Debug.Log("ID: " + id);
    }
    
}
