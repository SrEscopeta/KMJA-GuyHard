using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canEnter : MonoBehaviour
{
    public GameObject Puertas;
    public GameObject Can;

    public bool can = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "JonasYonqui" || other.gameObject.name == "JonasUltimo")
        {
            can = false;
            Can.gameObject.GetComponent<Text>().enabled = true;
        }
        if(other.gameObject.name == "Jonas")
        {
            can = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        can = true;
        Can.gameObject.GetComponent<Text>().enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        Can = GameObject.Find("YouCan");
        Puertas = GameObject.Find("Puertas");
        Can.gameObject.GetComponent<Text>().enabled = false;
        Puertas.SetActive(can);
    }

    // Update is called once per frame
    void Update()
    {
        Puertas.SetActive(can);
        Can = GameObject.Find("YouCan");
    }
}
