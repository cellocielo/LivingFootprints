using UnityEngine;
using TMPro;

public class DigitalClock : MonoBehaviour 
{
    public TextMeshProUGUI clockText;
    public float timeMultiplier = 100f;
    private static float savedTimeElapsed = 0f;
    private float timeElapsed = 0f;

    private bool isPaused = false;
    public static DigitalClock Instance;

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
            return;
        }
        timeElapsed = savedTimeElapsed;
    }

    void Update() {
        if (!isPaused) {
            timeElapsed += Time.deltaTime * timeMultiplier;
            savedTimeElapsed = timeElapsed;
        }

        int hours = Mathf.FloorToInt(timeElapsed / 3600) % 24;
        int minutes = Mathf.FloorToInt((timeElapsed % 3600) / 60);
        int displayHour = (hours % 12 == 0) ? 12 : hours % 12;
        string sign = (hours >= 12) ? "PM" : "AM";

        if (clockText != null) {
            string timeString = string.Format("{0:D2}:{1:D2} {2}", displayHour, minutes, sign);
            clockText.text = timeString;
        }
    }

    public void TogglePause() {
        isPaused = !isPaused;
    }

    public int GetCurrentHour() {
        return Mathf.FloorToInt(timeElapsed / 3600) % 24;
    }

    public int GetCurrentMinute() {
        return Mathf.FloorToInt((timeElapsed % 3600) / 60);
    }

    public void SetClockText(TextMeshProUGUI newText) {
        clockText = newText;
    }
}
