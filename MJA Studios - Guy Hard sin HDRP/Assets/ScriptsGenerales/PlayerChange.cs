﻿
using UnityEngine;
using UnityEngine.UI;

namespace CoverShooter
{
    public class PlayerChange : MonoBehaviour
    {
        public GameObject player2;
        public GameObject player1;
        //public Camera Camera2;
        public GameObject Camera1;
        public GameObject text;

        //public bool camera2;
        //public bool camera1 = true;
        public bool activePlayer2;
        public bool activePlayer1 = true;



        private void Start()
        {
            player2.SetActive(activePlayer2);
            player1.SetActive(activePlayer1);

            //Camera2.enabled = false;
            Camera1 = GameObject.FindGameObjectWithTag("MainCamera");
            text = GameObject.Find("Change");

            count = 0;
        }

        int count;
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {

                text.gameObject.GetComponent<Text>().enabled = true;
                if (Input.GetKeyDown(KeyCode.E) && count == 0)
                {
                    activePlayer2 = !activePlayer2;
                    activePlayer1 = !activePlayer1;
                    //camera1 = !camera1;
                    //camera2 = !camera2;

                    player2.SetActive(activePlayer2);
                    player1.SetActive(activePlayer1);
                    //Camera2.enabled = camera2;
                    //Camera1.enabled = camera1;
                    count += 1;
                    Camera1.gameObject.GetComponent<ThirdPersonCamera>().Target = player2.gameObject.GetComponent<CharacterMotor>();
    

            }

            }
        }
        private void OnTriggerExit(Collider other)
        {
            text.gameObject.GetComponent<Text>().enabled = false;
            count = 0;
        }

    }
}
