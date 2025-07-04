using UnityEngine;

public class MenuController : MonoBehaviour {
    public GameObject housePlay;
    public GameObject apartmentPlay;
    public GameObject houseBorder;
    public GameObject apartmentBorder;
    public GameObject apartmentButton;
    public GameObject houseButton;
    public GameObject howToPlayButton;
    public GameObject title;
    public GameObject options;
    public GameObject scrollArea;
    public GameObject closeScrollArea;
    
    public void showApartmentImage() {
        housePlay.gameObject.SetActive(false);
        apartmentPlay.gameObject.SetActive(true);
        houseBorder.gameObject.SetActive(false);
        apartmentBorder.gameObject.SetActive(true);
        scrollArea.gameObject.SetActive(false);
    }

    public void showHouseImage() {
        apartmentPlay.gameObject.SetActive(false);
        housePlay.gameObject.SetActive(true);
        apartmentBorder.gameObject.SetActive(false);
        houseBorder.gameObject.SetActive(true);
        scrollArea.gameObject.SetActive(false);
    }

    public void showHowTo() {
        apartmentBorder.gameObject.SetActive(false);
        houseBorder.gameObject.SetActive(false);
        housePlay.gameObject.SetActive(false);
        apartmentPlay.gameObject.SetActive(false);
        scrollArea.SetActive(true);
        apartmentButton.gameObject.SetActive(false);
        houseButton.gameObject.SetActive(false);
        howToPlayButton.gameObject.SetActive(false);
        title.gameObject.SetActive(false);
        options.gameObject.SetActive(false);
        scrollArea.gameObject.SetActive(true);
        closeScrollArea.gameObject.SetActive(true);
    }

    public void closeScollArea() {
        scrollArea.gameObject.SetActive(false);
        closeScrollArea.gameObject.SetActive(false);
        title.gameObject.SetActive(true);
        houseButton.gameObject.SetActive(true);
        apartmentButton.gameObject.SetActive(true);
        howToPlayButton.gameObject.SetActive(true);
        options.gameObject.SetActive(true);
    }
}
