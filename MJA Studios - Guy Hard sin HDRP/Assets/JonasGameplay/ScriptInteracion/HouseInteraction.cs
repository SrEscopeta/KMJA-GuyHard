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
    private bool hTrigger = false;// H luz
    private bool sTrigget = false;// S luz
    public bool LHabitacion;
    public bool LSalon;

    void Start()
    {
        LucesSalon = GameObject.Find("Salon");
        lucesHabitacion = GameObject.Find("habitacion");
        LHabitacion = true;
        LSalon = true;
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
            hTrigger = true;
            if (LHabitacion == true && Input.GetKeyDown(KeyCode.E))
            {
                lucesHabitacion.SetActive(false);
                LHabitacion = false;
            }
            if (LHabitacion == false && Input.GetKeyDown(KeyCode.E))
            {
                lucesHabitacion.SetActive(true);
                LHabitacion = true;
            }


        }

        if(other.name == "interruptorSalon")
        {
            sTrigget = true;
            if (LSalon == true && Input.GetKeyDown(KeyCode.E))
            {

                LucesSalon.SetActive(false);
                LSalon = false;
                
            }
            if (LSalon == false && Input.GetKeyDown(KeyCode.E))
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
        hTrigger = false;
        sTrigget = false;
        //LHabitacion = false;
    }
    private void Update()
    {
        
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
        if (hTrigger)
        {
            GUI.Box(new Rect(50, 80, 50, 25), "E");
            GUI.Box(new Rect(0, 50, 200, 25), "Apagar Luces.");
        }
        if(LHabitacion == false && hTrigger)
        {
            GUI.Box(new Rect(50, 80, 50, 25), "E");
            GUI.Box(new Rect(0, 50, 200, 25), "Encender Luces.");
        }
        
        if (sTrigget)
        {
            GUI.Box(new Rect(50, 80, 50, 25), "E");
            GUI.Box(new Rect(0, 50, 200, 25), "Apagar Luces.");
            
        }
        if(LSalon == false && sTrigget)
        {
            GUI.Box(new Rect(50, 80, 50, 25), "E");
            GUI.Box(new Rect(0, 50, 200, 25), "Encender Luces.");
        }
        
    }
}
