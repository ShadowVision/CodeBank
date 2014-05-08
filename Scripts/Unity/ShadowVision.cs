using UnityEngine;
using System.Collections;

public class ShadowVision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	static public string padInt(int value, int numberOfDigits){
		return value.ToString ("D" + numberOfDigits.ToString ());
	}
}
