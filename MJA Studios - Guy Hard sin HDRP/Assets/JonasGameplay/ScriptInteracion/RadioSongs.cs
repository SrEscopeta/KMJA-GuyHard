using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSongs : MonoBehaviour
{
    private AudioSource audioSource;
    [Header("Radio Songs")]
    public AudioClip[] Music;
    private AudioClip Song;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int index = Random.Range(0, Music.Length);
            Song = Music[index];
            audioSource.clip = Song;
            audioSource.Play();
        }
    }
}
