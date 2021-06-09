using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    public string timeRemainingInStr;
    public bool timerIsRunning = false;


    private float timeRemainingInDays = 1;
    private float timeRemainingInHours = 1;
    private float timeRemainingInMinutes = 5;
    private float timeRemainingInSeconds = 1;

    public Timer(string time)
    {
        timeRemainingInStr = time;
    }

    public void StartCountDown()
    {
        // Starts the timer automatically
        timerIsRunning = true;

        char days = timeRemainingInStr.Split(' ')[0][0];
        timeRemainingInDays = int.Parse(days.ToString());
        char hours = timeRemainingInStr.Split(' ')[1][0];
        timeRemainingInHours = int.Parse(hours.ToString());
        char minutes = timeRemainingInStr.Split(' ')[2][0];
        timeRemainingInMinutes = int.Parse(minutes.ToString());
    }

    public void UpdateCountDown()
    {
        if (timerIsRunning)
        {
            if (timeRemainingInSeconds > 0)
            {
                timeRemainingInSeconds -= Time.deltaTime;
            }
            else if (timeRemainingInMinutes > 0)
            {
                timeRemainingInSeconds = 60;
                timeRemainingInMinutes--;
            }
            else if (timeRemainingInHours > 0)
            {
                timeRemainingInMinutes = 60;
                timeRemainingInHours--;
            }
            else if (timeRemainingInDays > 0)
            {
                timeRemainingInHours = 24;
                timeRemainingInDays--;
            }
            else
            {
                timerIsRunning = false;
            }
        }

        timeRemainingInStr = timeRemainingInDays.ToString() + "D" + " " + timeRemainingInHours.ToString() + "H" + " " + timeRemainingInMinutes.ToString() + "M" + " " + timeRemainingInSeconds.ToString() + "S" ;
    }
}