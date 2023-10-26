using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSystem : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public bool isSavingPosition = false;

    void CreateFile()

        void SaveObjectPosition(Transform _objTransform)

        string ReadFile(string _fileName, string _extension)

        Vector3 ParseStringToVector3(string input)

        public void SaveToJSON(string _fileName, objet _data);

    {
        // 1) Acceder al path del archivo
        //string fileName = "example";
           string fileName = "positions";
        string extenssion = ".txt";
        string path = Application.dataPath + "/Resources/" + fileName + extenssion;
        // 2) Crear un archivo, si no existe otro con el mismo nombre
        if (!File.Exists(path))
        {
            // podrias poner Debug.Log("El archivo no existe");
        // 3) Escribir dentro de archivo
            File.WriteAllText(path, "Hola");
        }
        // 4) Guardar o Almacenar el contenido del archivo
        string data = "Login Date: " + System.DateTime.Now + "\n";


        // 5) Agregar la informacion al archivo
        File.AppendAllText(path, data);
    }


    void SaveObjectPosition(Transform _objTransform)
    {
        string data = "Position: " + "(" + _objTransform.position.x.ToString() + ", "
                                        + _objTransform.position.y.ToString() + ", "
                                        + _objTransform.position.z.ToString() + ", "
                                        + "\n";

    }
    // Start is called before the first frame update
    void Start()
    {
        CreateFile();  
    }

    // Update is called once per frame
    void Update()
    {
        SaveObjectPosition(obj.transform);
    }
}
