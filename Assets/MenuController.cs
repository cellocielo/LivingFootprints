using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
    public GameObject closePages;
    public GameObject pages;
    public GameObject left;
    public GameObject right;
    
    public void showApartmentImage() {
        housePlay.gameObject.SetActive(false);
        apartmentPlay.gameObject.SetActive(true);
        houseBorder.gameObject.SetActive(false);
        apartmentBorder.gameObject.SetActive(true);
        pages.gameObject.SetActive(false);
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(false);
    }

    public void showHouseImage() {
        apartmentPlay.gameObject.SetActive(false);
        housePlay.gameObject.SetActive(true);
        apartmentBorder.gameObject.SetActive(false);
        houseBorder.gameObject.SetActive(true);
        pages.gameObject.SetActive(false);
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(false);
    }

    public void showHowTo() {
        apartmentBorder.gameObject.SetActive(false);
        houseBorder.gameObject.SetActive(false);
        housePlay.gameObject.SetActive(false);
        apartmentPlay.gameObject.SetActive(false);
        apartmentButton.gameObject.SetActive(false);
        houseButton.gameObject.SetActive(false);
        howToPlayButton.gameObject.SetActive(false);
        title.gameObject.SetActive(false);
        options.gameObject.SetActive(false);
        pages.gameObject.SetActive(true);
        closePages.gameObject.SetActive(true);
        left.gameObject.SetActive(true);
        right.gameObject.SetActive(true);
    }
    

    public void closePagePanel() {
        pages.gameObject.SetActive(false);
        closePages.gameObject.SetActive(false);
        title.gameObject.SetActive(true);
        houseButton.gameObject.SetActive(true);
        apartmentButton.gameObject.SetActive(true);
        howToPlayButton.gameObject.SetActive(true);
        options.gameObject.SetActive(true);
    }
}
