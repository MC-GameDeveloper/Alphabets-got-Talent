using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject elephantPrefabRef;
	private GameObject elephantInstance;
	public float animalSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
		
			elephantInstance = Instantiate (elephantPrefabRef);

		}
		if (elephantInstance) {
		
			transform.position = new Vector3(transform.position.x - animalSpeed,transform.position.y,transform.position.x);
		}
	}
}
