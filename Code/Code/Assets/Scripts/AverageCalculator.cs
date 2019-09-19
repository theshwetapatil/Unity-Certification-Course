using UnityEngine;
using System.Collections;

public class AverageCalculator : MonoBehaviour {
    public float num1;
    public float num2;
    
    // Use this for initialization
    void Start () {
        float avg = Average(num1, num2);
        print("START::avg = " + avg);
    }
	
	// Update is called once per frame
	void Update () {
        float avg = Average(num1, num2);
        print("UPDATE::avg = " + avg);
    }

    float Average(float num1, float num2)
    {
        return ((num1 + num2) / 2);
    }
}
