using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Text : MonoBehaviour {
	
	private InputField text;
	public GameObject elephantPrefabRef;
	private GameObject elephantInstance;
	public float animalSpeed;


	// Use this for initialization
	void Start () {
		
		text = GetComponent<InputField>();
		text.ActivateInputField();

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (text.text);

		MenuController ();
	}


	void MenuController(){
		int scene;

		scene = SceneManager.GetActiveScene().buildIndex;

		if (scene == 0) {

			if (text.text== "t") {

				SceneManager.LoadScene ("Tutorial");
				text.text = "";
			}
			if (text.text== "e") {

				SceneManager.LoadScene ("Main");
				text.text = "";
			}

		} else if (scene != 0) {

			if ((text.text== "e") && (text.text== "t")) {

				SceneManager.LoadScene ("Start");
				text.text = "";
				Debug.Log ("e and t");

			}
			SpawnPrefab ();
		}
	}

	void SpawnPrefab(){

		if (text.text== "e") {
			elephantInstance = Instantiate (elephantPrefabRef);

		
			text.text = "";

		}
	}
}
