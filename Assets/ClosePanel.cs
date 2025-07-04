using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClosePanel : MonoBehaviour 
{
    public Button x;
    public GameObject panelToClose;
    public GameObject text;

    void Start() {
        x.onClick.AddListener(ResumeGame);
    }

    public void ResumeGame() {
        Debug.Log("closing panel");
        panelToClose.SetActive(false);
        x.gameObject.SetActive(false);
        text.SetActive(false);
        Time.timeScale = 1f;
    }
}
