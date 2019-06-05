using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    public int countCasa = 0;
    public int countPuerto = 0;
    public int countComisaria = 0;
    public int countMcRonald = 0;

    public GameObject casaAsquerosa;

    private void Start()
    {
        casaAsquerosa = GameObject.FindGameObjectWithTag("Casa");
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Casa")
        {
            countCasa =+ 1;
        }

        if(other.gameObject.tag == "Puerto")
        {
            countPuerto = +1;
        }

        if (other.gameObject.tag == "Comisaria")
        {
            countComisaria = +1;
        }

        if (other.gameObject.tag == "McRonald")
        {
            countMcRonald = +1;
        }

    }

    private void Update()
    {
        if (countCasa > 1)
        {

            DestroyImmediate(casaAsquerosa);
        }
    }

}
