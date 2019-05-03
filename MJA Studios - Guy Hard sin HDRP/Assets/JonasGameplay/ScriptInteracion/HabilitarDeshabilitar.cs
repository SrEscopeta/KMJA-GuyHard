using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabilitarDeshabilitar : MonoBehaviour
{
    private GameObject LucesSalon;

    // Start is called before the first frame update
    void Start()
    {
        LucesSalon = GameObject.Find("Salon");

    }

    // Update is called once per frame
    void Update()
    {
        LucesSalon.SetActive(false);
    }

}
