using UnityEngine;
using TMPro;

public class DigitalClock : MonoBehaviour 
{
    public TextMeshProUGUI clockText;
    public float timeMultiplier = 100f;
    private float timeElapsed = 0f;
    private bool isPaused = false;

    void Update() {
       if (!isPaused) {
            timeElapsed += Time.deltaTime * timeMultiplier;
            int hours = Mathf.FloorToInt(timeElapsed / 3600) % 24;
            int minutes = Mathf.FloorToInt((timeElapsed % 3600) / 60);
            int displayHour;
            if (hours%12 == 0) {
                displayHour = 12;
            }
            else {
                displayHour = hours % 12;
            }

            string sign;
            if (hours >= 12) {
                sign = "PM";
            }
            else {
                sign = "AM";
            }

            string timeString = string.Format("{0:D2}:{1:D2} {2}", displayHour, minutes, sign);
            clockText.text = timeString;
        }
    }

    public void TogglePause() {
        isPaused = !isPaused;
    }

    public int GetCurrentHour() {
        return Mathf.FloorToInt(timeElapsed/3600)%24;
    }

    public int GetCurrentMinute() {
        return Mathf.FloorToInt((timeElapsed%3600)/60);
    }

}
