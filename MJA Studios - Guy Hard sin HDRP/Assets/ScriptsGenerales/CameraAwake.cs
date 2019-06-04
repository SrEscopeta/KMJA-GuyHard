using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CoverShooter
{
    public class CameraAwake : MonoBehaviour
    {
        public GameObject player;
        private void Awake()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            GetComponent<ThirdPersonCamera>().Target = player.gameObject.GetComponent<CharacterMotor>();

        }
        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            GetComponent<ThirdPersonCamera>().Target = player.gameObject.GetComponent<CharacterMotor>();
        }

        private void Update()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            GetComponent<ThirdPersonCamera>().Target = player.gameObject.GetComponent<CharacterMotor>();
        }
    }
}
