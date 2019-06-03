using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChange : MonoBehaviour
{
    public GameObject player2;
    public GameObject player1;
    public GameObject Camera;
    public GameObject text;

    public bool camera1;
    public bool activePlayer2;
    public bool activePlayer1 = true;

    public string tpPosition;

    private void Start()
    {
        player2.SetActive(activePlayer2);
        player1.SetActive(activePlayer1);

        Camera.SetActive(camera1);
        text = GameObject.Find("Change");
    }

    int count = 0;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.gameObject.GetComponent<Text>().enabled = true;
            if (Input.GetKeyDown(KeyCode.E) && count == 0)
            {
                activePlayer2 = !activePlayer2;
                activePlayer1 = !activePlayer1;
                camera1 = !camera1;

                player2.SetActive(activePlayer2);
                player1.SetActive(activePlayer1);
                Camera.SetActive(camera1);


                player2.gameObject.GetComponent<NoDestroy>().tpPosition = tpPosition;
                player1.gameObject.GetComponent<NoDestroy>().tpPosition = tpPosition;
                player1.gameObject.GetComponent<NoDestroy>().tpStart = true;
                player2.gameObject.GetComponent<NoDestroy>().tpStart = true;
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        text.gameObject.GetComponent<Text>().enabled = false;
    }

}
