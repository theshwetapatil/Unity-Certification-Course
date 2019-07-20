using UnityEngine;
using System.Collections;

public class LogMessages : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World!");
		Debug.LogError("Error::Cannot print Hello World");
		Debug.LogWarning("Warning::Dangerous to print Hello World");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
