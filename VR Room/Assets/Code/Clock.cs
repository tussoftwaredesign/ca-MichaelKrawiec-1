using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform hours, minutes, seconds;

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;

        seconds.localRotation = Quaternion.Euler(time.Second * secondsToDegrees, 0f, 0f);

        TimeSpan timespan = DateTime.Now.TimeOfDay;
        hours.localRotation =
            Quaternion.Euler((float)timespan.TotalHours * hoursToDegrees, 0f, 0f);
        minutes.localRotation =
            Quaternion.Euler((float)timespan.TotalMinutes * minutesToDegrees, 0f, 0f);

    }
}