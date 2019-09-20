﻿using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {
    public GameObject prefab;

	// Use this for initialization
	void Start () {
        Instantiate(prefab, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
        bool isClicked = Input.GetMouseButtonDown(0);
        if (isClicked)
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
	}
}
