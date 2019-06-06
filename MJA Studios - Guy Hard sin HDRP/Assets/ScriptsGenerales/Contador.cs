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
    public GameObject ChangeFinal;
    public GameObject cinematica;

    public GameObject Audio1;
    public GameObject Audio2;


    public bool Finales;

    private void Awake()
    {
        casaAsquerosa = GameObject.FindGameObjectWithTag("Casa");

        EnemigosFinales = GameObject.FindGameObjectWithTag("Final");
        ChangeYonqui = GameObject.Find("changeYonki");
        ChangeFinal = GameObject.Find("changeFinal"); 

        cinematica = GameObject.Find("Cinematica");

        Audio1 = GameObject.Find("Audio1");
        Audio2 = GameObject.Find("Audio2");
    }
    private void Start()
    {
        ChangeYonqui = GameObject.Find("changeYonki");
        ChangeFinal = GameObject.Find("changeFinal");

        casaAsquerosa = GameObject.FindGameObjectWithTag("Casa");
        EnemigosFinales = GameObject.FindGameObjectWithTag("Final");
        cinematica = GameObject.Find("Cinematica");

        ChangeFinal.SetActive(false);
        ChangeYonqui.SetActive(false);

        EnemigosFinales.SetActive(false);
        cinematica.SetActive(false);

        Audio1 = GameObject.Find("Audio1");
        Audio2 = GameObject.Find("Audio2");

        Audio1.SetActive(false);
        Audio2.SetActive(false);

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
        casaAsquerosa = GameObject.FindGameObjectWithTag("Casa");
        EnemigosFinales = GameObject.FindGameObjectWithTag("Final");
        ChangeYonqui = GameObject.Find("changeYonki");
        ChangeFinal = GameObject.Find("changeFinal");

        cinematica = GameObject.Find("Cinematica");

        Audio1 = GameObject.Find("Audio1");
        Audio2 = GameObject.Find("Audio2");

        if (countCasa >= 2)
        {
            DestroyImmediate(casaAsquerosa);
        }

        if(countPuerto < 3)
        {
            ChangeYonqui.SetActive(true);
            ChangeFinal.SetActive(false);
        }
        if(countPuerto == 2)
        {
            Audio2.SetActive(true);
        }
        if(countPuerto == 1)
        {
            Audio1.SetActive(true);
        }
        if (countPuerto >= 3)
        {
            EnemigosFinales.SetActive(true);
            cinematica.SetActive(true);
            ChangeFinal.SetActive(true);

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
        if(Audio1 || Audio2 == null)
        {
            return;
        }

    }


}
