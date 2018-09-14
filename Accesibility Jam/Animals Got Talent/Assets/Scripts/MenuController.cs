using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine.SceneManagement;
using UnityEngine;



public class MenuController : MonoBehaviour {

	void Update(){

		if(Input.GetKeyDown(KeyCode.E)){

			SceneManager.LoadScene ("Tutorial");

		}
		if(Input.GetKeyDown(KeyCode.T)){

			SceneManager.LoadScene("Main");
		}
	}
}
