using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordIron : SwordBase
{
    public override void GetInfo()
    {
        base.GetInfo();

        NombreObjeto = "Espada de Hierro";
        Debug.Log("Nombre Objeto" + NombreObjeto);

        Elemento = "Hierro";
        Debug.Log("Espada Elemento" + Elemento);

        Color = "Plateado";
        Debug.Log("Espada Color" + Color);

        Gravedad = 1;
        Debug.Log("Espada Gravedad" + Gravedad);

        Densidad = 1;
        Debug.Log("Espada Densidad" + Densidad);

        Da�o = 10;
        Debug.Log("Espada Da�o" + Da�o);

        Tama�o = 1;
        Debug.Log("Espada Tama�o" + Tama�o);

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
}

