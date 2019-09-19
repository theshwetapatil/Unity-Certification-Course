using UnityEngine;
using System.Collections;

public class ForceCalculator : MonoBehaviour {

    // Use this for initialization
    public float accelerationDueToGravity = 9.81f;

    void Start () {
        print("Acceleration Due To Gravity: " + accelerationDueToGravity);
        print("Force on 10kg mass = " + ForceDueToGravity(10));
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    float ForceDueToGravity(float mass)
    {
        return (mass * accelerationDueToGravity);
    }
}
