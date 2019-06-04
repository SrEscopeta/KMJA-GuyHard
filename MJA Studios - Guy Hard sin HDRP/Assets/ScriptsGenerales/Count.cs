using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    int countCasa = 0;
    int countPuerto = 0;
    int countComisaria = 0;
    int countMcRonald = 0;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "casa")
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

    private void OnTriggerExit(Collider other)
    {
        
    }

}
