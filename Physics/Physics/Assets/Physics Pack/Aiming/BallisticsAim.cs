﻿using UnityEngine;
using System.Collections;

// Viewfinder class for the ballistics solving code.
public class BallisticsAim : MonoBehaviour
{

    public BallisticSolver solver;

    void Update()
    {
        var ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, 1<<8))
        {
            // Tell the ballistics solver what to aim for.
            //print(hitInfo.point);
            solver.target = hitInfo.point;
        }
    }
}
