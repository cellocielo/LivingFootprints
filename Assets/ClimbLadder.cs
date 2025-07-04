using UnityEngine;

public class ClimbLadder : MonoBehaviour
{
    public float climbSpeed = 3f;
    private bool isClimbing = false;
    private PlayerMovement playerMovementScript;

    void Start() {
        playerMovementScript = GetComponent<PlayerMovement>(); 
    }

    void Update() {
        if (isClimbing)
        {
            playerMovementScript.moveVelocity = new Vector3(0, climbSpeed, 0); 
            playerMovementScript.GetComponent<CharacterController>().Move(playerMovementScript.moveVelocity * Time.deltaTime); 
        }
        else
        {
            playerMovementScript.moveVelocity.y += playerMovementScript.gravity * Time.deltaTime;
            playerMovementScript.GetComponent<CharacterController>().Move(playerMovementScript.moveVelocity * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ladder")) {
            isClimbing = true;
            playerMovementScript.moveVelocity.y = 0;
            playerMovementScript.gravity = 0;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Ladder")) {
            isClimbing = false;
            playerMovementScript.gravity = -9.81f;
        }
    }
}
