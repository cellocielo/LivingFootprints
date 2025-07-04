using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Animator playerAnim;
    public float w_speed, wb_speed, ro_speed;
    public float jumpSpeed = 8;
    public float gravity = -9.81f;
    public bool walking;
    public Transform playerTrans;

    private bool isGrounded;
    private CharacterController CharacterController;
    public Vector3 moveVelocity;
    private Vector3 turnVelocity;

    void Start() {
        CharacterController = GetComponent<CharacterController>();
        if (playerTrans == null) {
            playerTrans = transform;
        }
        transform.position = GameManager.spawnPosition;
    }

    void Update() {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        
        Vector3 move = transform.forward * vInput * w_speed;

        moveVelocity = new Vector3(move.x, moveVelocity.y, move.z);

        if (CharacterController.isGrounded) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                moveVelocity.y = jumpSpeed;
            }
        }

        moveVelocity.y += gravity * Time.deltaTime;

        turnVelocity = transform.up * ro_speed * hInput;
        transform.Rotate(turnVelocity * Time.deltaTime);

        CharacterController.Move(moveVelocity * Time.deltaTime);

        bool isWalkingForward = vInput > 0.1f;
        bool isWalkingBackward = vInput < -0.1f;

        playerAnim.SetBool("isWalkingForward", isWalkingForward);
        playerAnim.SetBool("isWalkingBackward", isWalkingBackward);
        walking = isWalkingForward || isWalkingBackward;

        if (Input.GetKey(KeyCode.A)) {
            playerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            playerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);
        }
    }
}
