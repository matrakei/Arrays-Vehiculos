using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEHICULOSMANAGER : MonoBehaviour
{

    public Vehiculo vehiculoScript;


    // Start is called before the first frame update
    void Start()
    {
        int cantRuedasVehiculo = vehiculoScript.cantRuedas;
        Debug.Log("Cant Ruedas: " + cantRuedasVehiculo);
        if (cantRuedasVehiculo < 6) 
        {
            vehiculoScript.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
