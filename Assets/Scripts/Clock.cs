using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    // ** public and serialize field declarations ** //
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    // ** private vvariables ** //
    // Constant variables for conversions from time to degree
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    
    // storage variable for time
    //private DateTime time;
    private TimeSpan time;

    // Executes when component awakens
    void Update()
    {
        time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }

}
