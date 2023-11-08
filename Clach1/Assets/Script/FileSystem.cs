using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.Rendering;
using System.Runtime.Serialization.Formatters.Binary;

public class FileSystem : MonoBehaviour
{
    public static FileSystem instance;
    

    private void Awake()
    {
        if(instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }
    
    string ReadFile(string _FileName, string _Extension)
    {
        
        string path = Application.dataPath + "/Resources/" + _FileName + _Extension;
        string data = "";
        if (File.Exists(path))
        {
            data = File.ReadAllText(path);
        }
       
        return data;
    }

    

    
   public  T LoadFromJSON<T>(string _fileName) where T : new()
    {
        T data = new T();
        string JSonData = ReadFile(_fileName, ".json");
        //string DataRead = 
        if(JSonData.Length != 0)
        {
            Debug.Log("data: " + JSonData);
            JsonUtility.FromJsonOverwrite(JSonData, data);
        }
        else
        {
            Debug.Log("tas ReWey");
        }
        return data;
    }
    
   
    
  
    void Start()
    {
        
     
    }

    
    void Update()
    {
  
    }
}
