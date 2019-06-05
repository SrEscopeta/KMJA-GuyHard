using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camello : MonoBehaviour
{

    public Animator animator;
    public bool CanRun;
    private string RunNow = "Run";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CanRun = false;

            animator.SetBool(RunNow, CanRun);

        }
    }

    private void OnTriggerExit(Collider other)
    {

        CanRun = true;
        animator.SetBool(RunNow, CanRun);
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


}
