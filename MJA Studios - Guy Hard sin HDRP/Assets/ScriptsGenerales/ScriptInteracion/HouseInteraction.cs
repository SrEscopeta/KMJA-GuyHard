using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseInteraction : MonoBehaviour
{
    [Header("Objetos Interactuables")]
    public GameObject Radio;
    public GameObject aspasVentilador;



    private bool radioActive = false;
    private bool radioTriger = false;
    private bool aspasTrigger = false;


    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Ventilador")
        {
            aspasTrigger = true;
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                aspasVentilador.GetComponent<rotation>().enabled = true;
                
            }
        }

        if(other.name == "Radio")
        {
            radioTriger = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                Radio.GetComponent<RadioSongs>().enabled = true;
            }
        }


    }

    private void OnTriggerExit(Collider other)
    {
      
        aspasTrigger = false;
        radioTriger = false;

       
    }
    private void Update()
    {
        Radio = GameObject.Find("Radio");
        aspasVentilador = GameObject.Find("Ventilador");


    }

    void OnGUI()
    {
        if (aspasTrigger)
        {
            //GUI.Box(new Rect(0, 60, 200, 25), "Hace demasiado calor, creo que algo de aire no me vendría mal.");
            GUI.Box(new Rect(0, 500, 400, 25), "Hace demasiado calor, creo que algo de aire no me vendría mal.");
            GUI.Box(new Rect(50, 80, 50, 25), "E");
            GUI.Box(new Rect(0, 50, 200, 25), "Encender ventilador");
        }
        if (radioTriger)
        {
            GUI.Box(new Rect(50, 80, 50, 25), "E");
            GUI.Box(new Rect(0, 50, 200, 25), "Encender Radio.");
        }
 
        
    
        
    }
}
