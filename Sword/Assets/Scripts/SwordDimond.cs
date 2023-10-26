using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDimond : SwordBase
{
    public override void GetInfo()
    {
        base.GetInfo();

        NombreObjeto = "Espada de Diamante";
        Debug.Log("Nombre Objeto" + NombreObjeto);

        Elemento = "Diamante";
        Debug.Log("Espada Elemento" + Elemento);

        Color = "Azul";
        Debug.Log("Espada Color" + Color);

        Gravedad = 1;
        Debug.Log("Espada Gravedad" + Gravedad);

        Densidad = 1;
        Debug.Log("Espada Densidad" + Densidad);

        Daño = 15;
        Debug.Log("Espada Daño" + Daño);

        Tamaño = 1;
        Debug.Log("Espada Tamaño" + Tamaño);

    }
    // Start is called before the first frame update
    void Start()
    {
        GetInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
