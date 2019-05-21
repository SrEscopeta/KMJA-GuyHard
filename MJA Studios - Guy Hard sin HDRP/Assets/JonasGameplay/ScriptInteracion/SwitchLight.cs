using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    private float distance;
    public Transform player;
    public GameObject myLight;
    public bool power;
    // Start is called before the first frame update
    void Start()
    {
        myLight.SetActive(power);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);

        if(distance < 2)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                power = !power;
                myLight.SetActive(power);
            }
        }
    }
}
