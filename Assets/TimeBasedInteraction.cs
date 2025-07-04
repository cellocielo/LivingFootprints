using UnityEngine;
using TMPro;

public class TimeBasedInteraction : MonoBehaviour
{
    public DigitalClock clock;
    public TextMeshProUGUI rateText;

    public string GetTimeBasedMessage() {
        int hour = clock.GetCurrentHour();

        if (hour >= 22 || hour < 6)
        {
            return "You are using electricity during periods of low demand! (10PM - 6AM)";
        }
        else if (hour >= 16 && hour < 22)
        {
            return "You are using electricity during periods of high demand! (4PM - 10PM)";
        }
        else
        {
            return "You are using electricity during periods of moderate demand! (6AM - 4PM)";
        }
    }
}
