using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractPromptTrigger : MonoBehaviour {
    public string sceneToLoad;
    public GameObject promptUI;

    private bool isPlayerNear = false;

    void Start() {
        if (promptUI != null)
            promptUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            isPlayerNear = true;
            if (promptUI != null && !IsAnyUIActive())
                promptUI.SetActive(true);

            Debug.Log($"Player near {gameObject.name} - Press E to interact");
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            isPlayerNear = false;
            if (promptUI != null)
                promptUI.SetActive(false);
        }
    }

    void Update() {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E) && !IsAnyUIActive()) {
            SceneStateManager.StorePlayerPosition();
            SetSceneUIFlag();
            SceneManager.LoadScene(sceneToLoad);
        }
        
        if (isPlayerNear && promptUI != null)
        {
            promptUI.SetActive(!IsAnyUIActive());
        }
    }
    private void SetSceneUIFlag() {
        SceneStateManager.ResetFlags();

        if (gameObject.CompareTag("Plants")) {
            SceneStateManager.showPlantsUI = true;
        }
        else if (gameObject.CompareTag("Fridge")) {
            SceneStateManager.showFridgeUI = true;
        }
        else if (gameObject.CompareTag("Vacuum")) {
            SceneStateManager.showVacuumUI = true;
        }
        else if (gameObject.CompareTag("Pill")) {
            SceneStateManager.showPillUI = true;
        }
        else if (gameObject.CompareTag("Laundry")) {
            SceneStateManager.showLaundryUI = true;
        }
        else if (gameObject.CompareTag("Tree")) {
            SceneStateManager.showTreeUI = true; }
        else if (gameObject.CompareTag("Rain Barrel")) {
            SceneStateManager.showRainBarrelUI = true;
        }
        else if (gameObject.CompareTag("Solar Panel")) {
            SceneStateManager.showSolarPanelUI = true;
        } else if (gameObject.CompareTag("Pizza Box"))
        {
            SceneStateManager.showPizzaBoxUI = true;
        }
        else if (gameObject.CompareTag("E-Waste"))  {
            SceneStateManager.showEWasteUI = true; }
        else if (gameObject.CompareTag("Pan")) {
            SceneStateManager.showPanUI = true;
        }
    }

      private bool IsAnyUIActive() {
            GameObject[] uiObjects = GameObject.FindGameObjectsWithTag("UIPopUp");
            foreach (GameObject ui in uiObjects) {
                if (ui.activeInHierarchy)
                    return true;
            }
            return false;
        }
}
