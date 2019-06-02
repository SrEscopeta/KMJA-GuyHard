using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente : MonoBehaviour
{
    public GameObject trigger;

    private void OnTriggerExit(Collider other)
    {
        trigger.GetComponent<AudioSource>().enabled = false;
    }
}
