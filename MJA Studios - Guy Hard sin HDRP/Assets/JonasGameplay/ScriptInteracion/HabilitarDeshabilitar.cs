using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabilitarDeshabilitar : MonoBehaviour
{
    private GameObject LucesSalon;
    private GameObject lucesHabitacion;
    // Start is called before the first frame update
    void Start()
    {
        LucesSalon = GameObject.Find("Salon");
        lucesHabitacion = GameObject.Find("habitacion");
    }

    // Update is called once per frame
    void Update()
    {
        lucesHabitacion.SetActive(false);
        LucesSalon.SetActive(false);
    }
}
