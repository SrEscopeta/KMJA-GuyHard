using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour {
	public GameObject pj;
	public float distance;
	public GameObject text;
	public string nombreScene;
	public string tpPosition;
	// Use this for initialization
	void Start () {
		pj = GameObject.FindGameObjectWithTag ("Player");
		text = GameObject.Find ("Epuerta");
	
	}

    // Update is called once per frame
    void Update() {
        pj = GameObject.FindGameObjectWithTag("Player");
        distance = Vector3.Distance(pj.transform.position, transform.position);

        if (distance < 1.7) {
            text.gameObject.GetComponent<Text>().enabled = true;
            if (Input.GetKey(KeyCode.E)) {
                SceneManager.LoadScene(nombreScene);
                pj.gameObject.GetComponent<NoDestroy>().tpPosition = tpPosition;
                pj.gameObject.GetComponent<NoDestroy>().tpStart = true;
            }


        } else {
            text.gameObject.GetComponent<Text>().enabled = false;
        }
    }
	
	}

