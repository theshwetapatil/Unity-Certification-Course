using UnityEngine;
using System.Collections;

public class LocationGetter : MonoBehaviour {

    // Use this for initialization
    public Vector3 location;
	void Start () {
        Vector3 currentLocation = new Vector3(1.0f, 2.0f, 3.0f);
        Vector3 home = new Vector3(2.0f, 4.0f, 5.0f);
        Vector3 distance = (home - currentLocation);
        print("currentLocation = " + currentLocation);
        print("home = " + home);
        print("distance = " + distance.magnitude);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
