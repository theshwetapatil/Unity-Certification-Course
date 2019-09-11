using UnityEngine;
using System.Collections;

public class TagBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var shapes = GameObject.FindGameObjectsWithTag("Shape");
		var respawnPT = GameObject.FindGameObjectWithTag("Respwan");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
