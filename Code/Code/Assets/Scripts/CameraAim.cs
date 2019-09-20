using UnityEngine;
using System.Collections;

public class CameraAim : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Debug.DrawRay(transform.position, Vector3.forward, Color.red, 10);
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    public Ray GetAimRay()
    {
        Camera cam = GetComponent<Camera>();
        Vector3 mousePos = Input.mousePosition;
        Ray aimRay = cam.ScreenPointToRay(mousePos);
        Debug.DrawRay(aimRay.origin, aimRay.direction, Color.red);
        return aimRay;
    }
}
