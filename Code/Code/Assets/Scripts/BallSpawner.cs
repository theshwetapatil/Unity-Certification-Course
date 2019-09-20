using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {
    public GameObject prefab;
    public CameraAim aimComponent;

	// Use this for initialization
	void Start () {
        Instantiate(prefab, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
        bool isClicked = Input.GetMouseButtonDown(0);
        if (isClicked)
        {
            Ray aimRay = aimComponent.GetAimRay();
            Quaternion aimRotation = Quaternion.LookRotation(aimRay.direction);
            Instantiate(prefab, transform.position, aimRotation);
        }
	}
}
