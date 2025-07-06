using UnityEngine;
using System.Collections;

public class PlayerPositionRestorer : MonoBehaviour 
{
    void Start()
    {
        if (SceneStateManager.hasStoredPosition)
        {
            StartCoroutine(RestorePlayerPositionDelayed());
        }
    }
    
    IEnumerator RestorePlayerPositionDelayed()
    {
        yield return null;
        
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
        
            CharacterController controller = player.GetComponent<CharacterController>();
            if (controller != null)
            {
                controller.enabled = false;
                player.transform.position = SceneStateManager.savedPlayerPosition;
                controller.enabled = true;
                Debug.Log($"Used Character Controller method to restore position");
            }
            else
            {
                player.transform.position = SceneStateManager.savedPlayerPosition;
            }
             
            SceneStateManager.hasStoredPosition = false;
        }
        else
        {
            Debug.LogWarning("Player object not found when trying to restore position!");
        }
    }
}