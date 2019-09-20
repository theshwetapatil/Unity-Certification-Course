using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

    Vector3 newPosition;
    int speed = -5;
    public int force = -5;
    bool launched = false;

    // Use this for initialization
    void Start () {
        
    }
	
    public void UpdatePosition()
    {
        Transform trans = GetComponent<Transform>();
        trans.position = newPosition;
    }

	// Update is called once per frame
	void Update () {
        //UpdatePosition();
        //Vector3 offset = new Vector3(0, speed * Time.deltaTime, 0);
        //transform.position += offset;
	}

    void FixedUpdate()
    {
        if (!launched)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 offsetForce = new Vector3(0, force, 0);
            rb.AddForce(offsetForce, ForceMode.Impulse);
            launched = true;
        }
    }
}
