using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class AnalyticsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Gender gender = Gender.Female;
        Analytics.SetUserGender(gender);

        int birthYear = 2014;
        Analytics.SetUserBirthYear(birthYear);

        LevelUp();
	}
	
    void LevelUp()
    {
        Analytics.Transaction("levelUp", 1, "INR", null, null);

        Analytics.CustomEvent("levelUp", new Dictionary<string, object>
        {
            { "newLevgel", 2 },
            { "trigger", "purchase" },
        });
    }
	// Update is called once per frame
	void Update () {
	
	}
}
