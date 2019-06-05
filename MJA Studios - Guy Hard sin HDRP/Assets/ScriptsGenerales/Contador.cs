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

    public GameObject EnemigosFinales;
    public GameObject ChangeYonqui;

    public GameObject cinematica;


    public bool Finales;

    private void Awake()
    {
        EnemigosFinales = GameObject.FindGameObjectWithTag("Final");
        ChangeYonqui = GameObject.Find("changeYonki");
        cinematica = GameObject.Find("Cinematica");
    }
    private void Start()
    {
        casaAsquerosa = GameObject.FindGameObjectWithTag("Casa");
        EnemigosFinales = GameObject.FindGameObjectWithTag("Final");
        cinematica = GameObject.Find("Cinematica");
        EnemigosFinales.SetActive(false);
        cinematica.SetActive(false);
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
            countPuerto ++;
            Debug.Log("valor: " + countPuerto);
        }

        if (other.gameObject.tag == "Comisaria")
        {
            countComisaria ++;
        }

        if (other.gameObject.tag == "McRonald")
        {
            countMcRonald ++;
        }
    }

    private void Update()
    {
       
        if (countCasa >= 2)
        {
            DestroyImmediate(casaAsquerosa);
        }

        if (countPuerto >= 3)
        {
            EnemigosFinales.SetActive(true);
            cinematica.SetActive(true);
            Destroy(ChangeYonqui);

            Finales = true;

        }
        else
        {
            EnemigosFinales.SetActive(false);

            Finales = false;

        }

        if (ChangeYonqui == null)
        {
            return;
        }

    }


}
