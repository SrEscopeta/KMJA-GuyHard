using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemys : MonoBehaviour
{

    Contador contador = new Contador();
    
    
    public GameObject EnemigosFinales;


    public bool Finales;


    private void Start()
    {
        EnemigosFinales.SetActive(false);
     
    }

    private void Update()
    {
        //SinArmasEnemys();

        if (contador.countPuerto > 2)
        {
            EnemigosFinales.SetActive(true);

            Finales = true;

        }
        else
        {
            EnemigosFinales.SetActive(false);

            Finales = false;

        }

    }

   
    //public void SinArmasEnemys()
    //{
    //    if (contador.countPuerto >= 3)
    //    {
    //        EnemigosFinales.SetActive(true);

    //        Finales = true;

    //    }
    //    else
    //    {
    //        EnemigosFinales.SetActive(false);

    //        Finales = false;

    //    }
    }

    



