using UnityEngine;
using System.Collections;

public class ConsoleWelcomer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Welcome");
        print("beginning...");
        Transform trans = GetComponent<Transform>();
        trans.position = new Vector3(1, 2, 3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
