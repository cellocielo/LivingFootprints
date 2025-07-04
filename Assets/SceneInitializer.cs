using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class SceneInitializer : MonoBehaviour
{
    public GameObject fridge;
    public GameObject fridgeX;
    public GameObject openGreenhouse;
    public GameObject openIrrigation;
    public GameObject openLand;
    public GameObject laundry;
    public Button laundryX;
    public Button dynamicPricing;
    public TextMeshProUGUI timeMessageText;
    public TimeBasedInteraction timeBasedInteraction;
    public Button openEnergyUsage;
    public DigitalClock clock;
    public GameObject vacuum;
    public Button vacuumX;
    public Button openEnergy;
    public GameObject plants;
    public Button plantsX;
    public Button pollutants;
    public Button temperature;
    public GameObject pill;
    public Button pillX;
    public Button openContaminants;
    public GameObject tree;
    public Button treeX;
    public GameObject rainBarrel;
    public Button rainBarrelX;
    public Button openDomesticWaterUsage;
    public GameObject solarPanel;
    public Button solarPanelX;
    public Button openSolarEnergy;
    public GameObject pizzaBox;
    public Button pizzaBoxX;
    public GameObject eWaste;
    public Button eWasteX;
    public GameObject pan;
    public GameObject panX;

    private void Start()
    {
        if (SceneStateManager.showFridgeUI)
        {
            fridge.SetActive(true);
            fridgeX.SetActive(true);
            openGreenhouse.gameObject.SetActive(true);
            openIrrigation.gameObject.SetActive(true);
            openLand.gameObject.SetActive(true);
            SceneStateManager.showFridgeUI = false;
        }

        if (SceneStateManager.showLaundryUI) {
            laundry.SetActive(true);
            laundryX.gameObject.SetActive(true);
            dynamicPricing.gameObject.SetActive(true);
            openEnergyUsage.gameObject.SetActive(true);
            timeMessageText.text = timeBasedInteraction.GetTimeBasedMessage();
            SceneStateManager.showLaundryUI = false;
        }

        if (SceneStateManager.showPlantsUI) {
            plants.SetActive(true);
            plantsX.gameObject.SetActive(true);
            pollutants.gameObject.SetActive(true);
            temperature.gameObject.SetActive(true);
            clock.TogglePause();
        }
        
        if (SceneStateManager.showVacuumUI) {
            vacuum.SetActive(true);
            vacuumX.gameObject.SetActive(true);
            openEnergy.gameObject.SetActive(true);
        }

        if (SceneStateManager.showPillUI) {
            pill.SetActive(true);
            pillX.gameObject.SetActive(true);
            openContaminants.gameObject.SetActive(true);
        }

        if (SceneStateManager.showTreeUI) {
            tree.SetActive(true);
            treeX.gameObject.SetActive(true);
        }

        if (SceneStateManager.showRainBarrelUI) {
            rainBarrel.SetActive(true);
            rainBarrelX.gameObject.SetActive(true);
            openDomesticWaterUsage.gameObject.SetActive(true);
        }

        if (SceneStateManager.showSolarPanelUI) {
            solarPanel.SetActive(true);
            solarPanelX.gameObject.SetActive(true);
            openSolarEnergy.gameObject.SetActive(true);
        }

        if (SceneStateManager.showPizzaBoxUI) {
            pizzaBox.SetActive(true);
            pizzaBoxX.gameObject.SetActive(true);
        }

        if (SceneStateManager.showEWasteUI) {
            eWaste.SetActive(true);
            eWasteX.gameObject.SetActive(true);
        }

        if (SceneStateManager.showPanUI) {
            pan.SetActive(true);
            panX.gameObject.SetActive(true);
        }
    }

    
}
