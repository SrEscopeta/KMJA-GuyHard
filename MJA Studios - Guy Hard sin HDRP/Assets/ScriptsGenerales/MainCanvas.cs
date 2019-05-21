using UnityEngine;
using System.Collections;

public class MainCanvas : MonoBehaviour {

	public static MainCanvas nodestroy;
	// Use this for initialization
	void Awake (){
		if (nodestroy == null) {
			nodestroy = this;
			DontDestroyOnLoad (this.gameObject.transform);
		}else if (nodestroy != this){
			Destroy (gameObject);
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
