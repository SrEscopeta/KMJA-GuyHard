using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interaccion : MonoBehaviour
{
    public GameObject text;
    public bool enter;
    public AudioClip audio;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Texto");
        
        source = GetComponent<AudioSource>();
    }

    int count = 0;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = true;
            text.gameObject.GetComponent<Text>().enabled = true;
            // Play the sound only on the trigger
            if (Input.GetKeyDown(KeyCode.E) && count == 0)
            {
                source.PlayOneShot(audio);
                count += 1 ;


            }
        }
        Debug.Log("Entered");
    }
    void OnTriggerExit(Collider other)
    {
        text.gameObject.GetComponent<Text>().enabled = false;
        if (other.gameObject.tag == "Player")
        {
            enter = false;
            count = 0;
        }
        Debug.Log("Exited");
    }

    private void Update()
    {
        text = GameObject.Find("Texto");
    }
}
