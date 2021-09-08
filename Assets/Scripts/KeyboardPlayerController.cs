using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class KeyboardPlayerController : MonoBehaviour {

    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    public bool AButton;
    public bool BButton;
    public Vector2 LeftStick;
    

    private Rigidbody rb;
    private int cubesPickedUp;
    private float movementX;
    private float movementY;

    //From Unity's roll a ball tutorial

    // Start is called before the first frame update
    void Start() {
        //grabs the rigidbody component from the player sphere
        rb = GetComponent<Rigidbody>();

        cubesPickedUp = 0;
        //SetCountText();
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate() {
        OVRInput.FixedUpdate();
        VRContollerInput();
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

    }

    void Update() {
        OVRInput.Update();
        AButton = OVRInput.Get(OVRInput.RawButton.A);
        if (AButton == true) {
            winTextObject.SetActive(true);
        }
    }


    void OnMove(InputValue movementValue) {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }


    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pickup")) {
            other.gameObject.SetActive(false);
            cubesPickedUp += 1;

            SetCountText();
        }
        
    }

    void SetCountText () {
        countText.text = "Count: " + cubesPickedUp.ToString();
        if (cubesPickedUp >= 12) {
            winTextObject.SetActive(true);
        }
    }

    void VRContollerInput() {
        // returns a Vector2 of the primary (typically the Left) thumbstick’s current state.
        // (X/Y range of -1.0f to 1.0f)
        var tempLeft = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        var tempRight = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        countText.text = tempLeft.ToString();
        if (tempLeft != null) {
            LeftStick = (tempLeft);
            movementX = tempLeft.x;
            movementY = tempLeft.y;
        }
        else if (tempRight != null) {
            movementX = tempRight.x;
            movementY = tempRight.y;
        }

        
    }


}
