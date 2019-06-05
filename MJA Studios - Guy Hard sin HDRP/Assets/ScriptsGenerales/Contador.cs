using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public int countCasa;
    public int countPuerto;
    public int countComisaria;
    public int countMcRonald;
    public GameObject casaAsquerosa;

    private void Start()
    {
        casaAsquerosa = GameObject.FindGameObjectWithTag("Casa");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Casa")
        {
            countCasa ++;
            Debug.Log("valor: " + countCasa);
        }

        if (other.gameObject.tag == "Puerto")
        {
           
        }

        if (other.gameObject.tag == "Comisaria")
        {
            
        }

        if (other.gameObject.tag == "McRonald")
        {
            
        }
    }

    private void Update()
    {
        if(countCasa >= 2)
        {
            DestroyImmediate(casaAsquerosa);
        }
    }


}
