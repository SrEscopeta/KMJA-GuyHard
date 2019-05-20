using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CambioEscena : MonoBehaviour
{
  

    public GameObject text;

    public string Escena;
    // Use this for initialization
    void Start()
    {
        
        text = GameObject.Find("Epuerta");

    }
   

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            text.gameObject.GetComponent<Text>().enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene(Escena);
            }
        }
        else
        {
            text.gameObject.GetComponent<Text>().enabled = false;
        }


    }
}