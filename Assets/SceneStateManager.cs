using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateManager : MonoBehaviour {
    public static bool showFridgeUI = false;
    public static bool showLaundryUI = false;
    public static bool showPlantsUI = false;
    public static bool showPanUI = false;
    public static bool showTreeUI = false;
    public static bool showPillUI = false;
    public static bool showEWasteUI = false;
    public static bool showSolarPanelUI = false;
    public static bool showPizzaBoxUI = false;
    public static bool showRainBarrelUI = false;
    public static bool showVacuumUI = false;

    public static Vector3 savedPlayerPosition;
    public static bool hasStoredPosition = false;

    public static void StorePlayerPosition()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            savedPlayerPosition = player.transform.position;
            hasStoredPosition = true;
            Debug.Log($"Stored player position: {savedPlayerPosition}");
        }
    }

    public static void CloseAndReturnToMain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public static void ResetFlags()
    {
        showPlantsUI = false;
        showFridgeUI = false;
        showVacuumUI = false;
        showPillUI = false;
        showLaundryUI = false;
        showTreeUI = false;
        showRainBarrelUI = false;
        showSolarPanelUI = false;
        showPizzaBoxUI = false;
        showEWasteUI = false;
        showPanUI = false;
    }
}
