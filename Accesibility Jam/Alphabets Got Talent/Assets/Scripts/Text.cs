using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Text : MonoBehaviour {
	
	private InputField text;
	public GameObject elephantPrefabRef;
	private GameObject elephantInstance;
	public GameObject tigerPrefabRef;
	private GameObject tigerInstance;
	public GameObject sheepPrefabRef;
	private GameObject sheepInstance;
	public GameObject alligatorPrefabRef;
	private GameObject alligatorInstance;
	public GameObject iguanaPrefabRef;
	private GameObject iguanaInstance;
	public GameObject monkeyPrefabRef;
	private GameObject monkeyInstance;
	public GameObject narwhalPrefabRef;
	private GameObject narwhalInstance;
	public GameObject owlPrefabRef;
	private GameObject owlInstance;

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
		if (text.text== "t") {
			tigerInstance = Instantiate (tigerPrefabRef);


			text.text = "";

		}
		if (text.text== "s") {
			sheepInstance = Instantiate (sheepPrefabRef);


			text.text = "";

		}
		if (text.text== "a") {
			alligatorInstance = Instantiate (alligatorPrefabRef);


			text.text = "";

		}
		if (text.text== "i") {
			iguanaInstance = Instantiate (iguanaPrefabRef);


			text.text = "";

		}
		if (text.text== "m") {
			monkeyInstance = Instantiate (monkeyPrefabRef);


			text.text = "";

		}
		if (text.text== "n") {
			narwhalInstance = Instantiate (narwhalPrefabRef);


			text.text = "";

		}
		if (text.text== "o") {
			owlInstance = Instantiate (owlPrefabRef);


			text.text = "";

		}
	}
}
