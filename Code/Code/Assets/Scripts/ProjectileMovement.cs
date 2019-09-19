using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

    Vector3 newPosition;
    public int speed = -5;
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
        Vector3 offset = new Vector3(0, speed * Time.deltaTime, 0);
        transform.position += offset;
	}
}
