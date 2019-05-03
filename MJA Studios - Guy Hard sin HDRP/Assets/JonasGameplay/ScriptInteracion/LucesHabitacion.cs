using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LucesHabitacion : MonoBehaviour
{
    public GameObject lucesHabitacion;
    private bool activate = true;
    // Start is called before the first frame update
    void Start()
    {
        lucesHabitacion = GameObject.Find("habitacion");
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(activate && Input.GetKeyDown(KeyCode.E))
        //{
        //    lucesHabitacion.SetActive(false);
        //    activate = false;
        //}

        //if(!activate && Input.GetKeyDown(KeyCode.E))
        //{
        //    lucesHabitacion.SetActive(true);
        //    activate = true;
        //}
        lucesHabitacion.SetActive(false);
    }
}
