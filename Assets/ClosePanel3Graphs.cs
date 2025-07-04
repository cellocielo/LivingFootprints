using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClosePanel3Graphs : MonoBehaviour 
{

    public Button x;
    public GameObject panelToClose;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    void Start() {
        x.onClick.AddListener(ResumeGame);
    }

    public void ResumeGame() {
        Debug.Log("closing panel");
        panelToClose.SetActive(false);
        x.gameObject.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        Time.timeScale = 1f;
    }
}
