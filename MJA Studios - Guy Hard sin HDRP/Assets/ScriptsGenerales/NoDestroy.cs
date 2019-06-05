using UnityEngine;
using System.Collections;

public class NoDestroy : MonoBehaviour {

	public GameObject position;
	public string tpPosition;
	public bool tpStart = false;
	public float tpCount;

	public static NoDestroy nodestroy;
	// Use this for initialization
	void Awake (){
		if (nodestroy == null) {
			nodestroy = this;
			DontDestroyOnLoad (this.gameObject.transform);
        }
        else if (nodestroy != this)
        {
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }

    }

    

    // Update is called once per frame
    void Update () {
		Teleport ();
	}

	void Teleport (){
		if (tpStart == true) {
			tpCount += Time.deltaTime;
			position = GameObject.Find (tpPosition);
			transform.position = position.transform.position;
			transform.rotation = position.transform.rotation;
			if (tpCount >= 0.5) {
				tpStart = false;
				tpCount = 0;
			}
		}
	}


}