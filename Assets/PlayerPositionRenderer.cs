using UnityEngine;

public class PlayerPositionRestorer : MonoBehaviour
{
    void Start()
    {
        if (SceneStateManager.hasStoredPosition)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                player.transform.position = SceneStateManager.savedPlayerPosition;
                Debug.Log($"Restored player position to: {SceneStateManager.savedPlayerPosition}");
                
                SceneStateManager.hasStoredPosition = false;
            }
        }
    }
}