using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
    public static Vector3 spawnPosition;

    public void SetHouseSpawn() {
        spawnPosition = new Vector3(14, -16, -11);
        SceneManager.LoadScene("SampleScene");
    }

    public void SetApartmentSpawn() {
        spawnPosition = new Vector3(2350, -17, 1711);
        SceneManager.LoadScene("SampleScene");
    }
}