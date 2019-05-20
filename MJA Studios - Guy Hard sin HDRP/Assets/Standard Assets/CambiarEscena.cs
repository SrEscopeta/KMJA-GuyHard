using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public string NombreEscena;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
{
            SceneManager.LoadScene(NombreEscena);
        }
    }
}

