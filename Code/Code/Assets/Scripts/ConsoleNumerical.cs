using UnityEngine;
using System.Collections;

public class ConsoleNumerical : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int INT = 2;
        float FLOAT = 2.0f;
        float sum = INT + FLOAT;
        float avg = sum / 2;
        print("INT = " + INT);
        print("FLOAT = " + FLOAT);
        print("sum = " + sum);
        print("avg = " + avg);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
