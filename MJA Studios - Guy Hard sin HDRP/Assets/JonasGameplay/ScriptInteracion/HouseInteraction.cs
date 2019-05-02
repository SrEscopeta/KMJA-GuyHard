using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseInteraction : MonoBehaviour
{
    [Header("Objetos Interactuables")]
    public GameObject Radio;
    public GameObject aspasVentilador;
    public GameObject LucesSalon;
    public GameObject lucesHabitacion;


    private bool radioActive = false;
    private bool radioTriger = false;
    private bool aspasTrigger = false;
    private bool LHabitacion = false;
    private bool LSalon = false;

    void Start()
    {
        LucesSalon = GameObject.Find("Salon");
        lucesHabitacion = GameObject.Find("habitacion");
    }

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
        if (other.name == "interruptorHabitacion")
        {
            LHabitacion = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                lucesHabitacion.SetActive(false);
                LHabitacion = false;
               
            }
            if (Input.GetKeyDown(KeyCode.E) && !LHabitacion)
            {
                lucesHabitacion.SetActive(true);
                LHabitacion = true;
            }
        }
        if(other.name == "interruptorSalon")
        {
            LSalon = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
             
                LucesSalon.SetActive(false);
                LSalon = false;
                
            }
            if (Input.GetKeyDown(KeyCode.E) && !LHabitacion)
            {
                LucesSalon.SetActive(true);
                LSalon = true;
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
      
        aspasTrigger = false;
        radioTriger = false;
        LSalon = false;
        LHabitacion = false;
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
        if (LHabitacion)
        {
            GUI.Box(new Rect(50, 80, 50, 25), "E");
            GUI.Box(new Rect(0, 50, 200, 25), "Apagar Luces.");
            if (!LHabitacion)
            {
                GUI.Box(new Rect(50, 80, 50, 25), "E");
                GUI.Box(new Rect(0, 50, 200, 25), "Encender Luces.");
            }
        }
        
        if (LSalon)
        {
            GUI.Box(new Rect(50, 80, 50, 25), "E");
            GUI.Box(new Rect(0, 50, 200, 25), "Apagar Luces.");
            if (!LSalon)
            {
                GUI.Box(new Rect(50, 80, 50, 25), "E");
                GUI.Box(new Rect(0, 50, 200, 25), "Encender Luces.");
            }
        }
        
    }
}
