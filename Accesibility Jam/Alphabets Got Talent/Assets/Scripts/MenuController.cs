using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine;



public class MenuController : MonoBehaviour {
	int scene;

	void Start(){
	


	}

	void Update(){

		scene = SceneManager.GetActiveScene().buildIndex;

		if (scene == 0) {
		
			if (Input.GetKey (KeyCode.E)) {

				SceneManager.LoadScene ("Tutorial");

			}
			if (Input.GetKey (KeyCode.T)) {

				SceneManager.LoadScene ("Main");
			}

		} else if (scene != 0) {

			if (Input.GetKey (KeyCode.E) && Input.GetKey (KeyCode.T)) {

				SceneManager.LoadScene ("Start");
				Debug.Log ("e and T");
			}
		}
	}
}
