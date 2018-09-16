using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KeyboardFocus : MonoBehaviour {
		private InputField text;
	void Start(){
		text = GetComponent<InputField>();
	}
		public void FocusKeyboard(){

			
			text.ActivateInputField();

		}
	}