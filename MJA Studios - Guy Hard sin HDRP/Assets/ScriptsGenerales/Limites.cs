using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{

    public GameObject limites;
    // Start is called before the first frame update
    void Start()
    {
        limites = GameObject.Find("Colliders");
        limites.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Car")
        {
            limites.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        limites.SetActive(false);
    }
}
