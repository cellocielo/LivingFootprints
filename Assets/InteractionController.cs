using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InteractionController : MonoBehaviour
{
    public SceneInitializer SceneInitializer;
    private bool isPlayerNear = false;
    private GameObject currentInteractableObject = null;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            isPlayerNear = true;
            currentInteractableObject = gameObject;
            Debug.Log($"Player near {gameObject.name} - Press E to interact");
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            currentInteractableObject = null;
        }
    }

    void Update() {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E) && currentInteractableObject != null)
        {
            HandleInteraction(currentInteractableObject);
        }
    }

    private void HandleInteraction(GameObject interactableObject) {
        if (interactableObject.CompareTag("Plants")) {
            SceneStateManager.showPlantsUI = true;
            SceneManager.LoadScene("PlantsScene");
        }
        else if (interactableObject.CompareTag("Fridge")) {
            SceneStateManager.showFridgeUI = true;
            SceneManager.LoadScene("FridgeScene");
        }
        else if (interactableObject.CompareTag("Vacuum")) {
            SceneStateManager.showVacuumUI = true;
            SceneManager.LoadScene("VacuumScene");
        }
        else if (interactableObject.CompareTag("Pill")) {
            SceneStateManager.showVacuumUI = true;
            SceneManager.LoadScene("PillScene");
        }
        else if (interactableObject.CompareTag("Laundry")) {
            Debug.Log("Laundry Clicked.");
            SceneStateManager.showLaundryUI = true;
            SceneManager.LoadScene("LaundryScene");
        }
        else if (interactableObject.CompareTag("Tree")) {
            Debug.Log("Hit Tree");
            SceneStateManager.showTreeUI = true;
            SceneManager.LoadScene("TreeScene");
        }
        else if (interactableObject.CompareTag("Rain Barrel")) {
            SceneStateManager.showRainBarrelUI = true;
            SceneManager.LoadScene("RainBarrelScene");
        }
        else if (interactableObject.CompareTag("Solar Panel")) {
            SceneStateManager.showSolarPanelUI = true;
            SceneManager.LoadScene("SolarPanelScene");
        }
        else if (interactableObject.CompareTag("Pizza Box")) {
            SceneStateManager.showPizzaBoxUI = true;
            SceneManager.LoadScene("PizzaBoxScene");
        }
        else if (interactableObject.CompareTag("E-Waste")) {
            SceneStateManager.showEWasteUI = true;
            SceneManager.LoadScene("EWasteScene");
        }
        else if (interactableObject.CompareTag("Pan")) {
            SceneStateManager.showPanUI = true;
            SceneManager.LoadScene("PanScene");
        }
    }
}