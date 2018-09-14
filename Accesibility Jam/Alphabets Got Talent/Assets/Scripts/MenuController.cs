using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine.SceneManagement;
using UnityEngine;



public class MenuController : MonoBehaviour {

	void Update(){

		if(Input.GetKey(KeyCode.E)){

			SceneManager.LoadScene ("Tutorial");

		}
		if(Input.GetKey(KeyCode.T)){

			SceneManager.LoadScene("Main");
		}
		if(Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.T)){

			SceneManager.LoadScene("Start");
			Debug.Log ("e and T");
		}
	}
}
