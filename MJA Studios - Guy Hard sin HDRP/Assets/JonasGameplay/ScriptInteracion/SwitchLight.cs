using UnityEngine;
using UnityEngine.UI;

public class SwitchLight : MonoBehaviour
{
    private float distance;
    public GameObject player;
    public GameObject myLight;
    public GameObject text;
    public bool power;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text = GameObject.Find("Luces");
        myLight.SetActive(power);

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.gameObject.transform.position, transform.position);

        if(distance < 2)
        {
            text.gameObject.GetComponent<Text>().enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                power = !power;
                myLight.SetActive(power);
            }
        }
        else
        {
            text.gameObject.GetComponent<Text>().enabled = false;
        }
    }
}
