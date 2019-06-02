using UnityEngine;
using System.Collections;

public class AudioPlay : MonoBehaviour
{
    public bool enter;
    public AudioClip audio;
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        enter = false;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        //if (enter == true) ;
           
    }

    int count = 0;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = true;
            // Play the sound only on the trigger
            if (enter && count <= 3)
            {
                source.PlayOneShot(audio);
                count -= 1;


            }
        }
        Debug.Log("Entered");
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = false;
            //count = 1;
        }
        Debug.Log("Exited");
    }
}
