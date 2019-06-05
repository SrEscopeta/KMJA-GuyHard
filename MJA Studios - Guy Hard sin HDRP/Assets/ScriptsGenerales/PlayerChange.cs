
using UnityEngine;
using UnityEngine.UI;

namespace CoverShooter
{
    public class PlayerChange : MonoBehaviour
    {
        public GameObject player2;
        public GameObject player1;

        public GameObject canvas1;
        public GameObject canvas2;

        public GameObject Camera1;
        public GameObject text;

        public bool activePlayer2;
        public bool activePlayer1 = true;

        public bool activeCanvas2;
        public bool activeCanvas1 = true;




        private void Start()
        {
            player2.SetActive(activePlayer2);
            player1.SetActive(activePlayer1);

            canvas2.SetActive(activeCanvas2);
            canvas1.SetActive(activeCanvas1);

            //Camera2.enabled = false;
            Camera1 = GameObject.FindGameObjectWithTag("MainCamera");
            text = GameObject.Find("Change");

            text.gameObject.GetComponent<Text>().enabled = false;

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

                    activeCanvas2 = !activeCanvas2;
                    activeCanvas1 = !activeCanvas1;

                    player2.SetActive(activePlayer2);
                    player1.SetActive(activePlayer1);

                    canvas2.SetActive(activeCanvas2);
                    canvas1.SetActive(activeCanvas1);

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
