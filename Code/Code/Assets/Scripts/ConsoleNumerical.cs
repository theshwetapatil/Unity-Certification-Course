using UnityEngine;
using System.Collections;

public class ConsoleNumerical : MonoBehaviour {

    // Use this for initialization
    void Start () {
        int INT = 2;
        float FLOAT = 2.0f;
        float FFLOAT = 4.0f;
        float sum = INT + FLOAT;
        float avg = Average(FLOAT, FFLOAT);
        float sqr = Square(Square(FLOAT));
        print("INT = " + INT);
        print("FLOAT = " + FLOAT);
        print("sum = " + sum);
        print("avg = " + avg);
        print("sqr = " + sqr);
	}

    float Square(float num)
    {
        return (num * num);
    }
    float Average(float num1, float num2)
    {
        return ((num1+num2)/2);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
