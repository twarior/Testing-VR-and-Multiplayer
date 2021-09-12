using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Runtime.InteropServices.ComTypes;
using Normal.Realtime;

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

    private RealtimeView _realtimeView;



    private void Awake() {
        _realtimeView = gameObject.GetComponentInParent(typeof(RealtimeView)) as RealtimeView;
    }



    //From Unity's roll a ball tutorial

    // Start is called before the first frame update
    void Start() {
        //grabs the rigidbody component from the player sphere
        rb = GetComponent<Rigidbody>();

        cubesPickedUp = 0;
        //SetCountText();
        winTextObject.SetActive(false);
    }

    private void Update() {
        // Call LocalUpdate() only if this instance is owned by the local client
        if (_realtimeView.isOwnedLocallyInHierarchy)
            LocalUpdate();
    }

    private void FixedUpdate() {
        // Call LocalFixedUpdate() only if this instance is owned by the local client
        if (_realtimeView.isOwnedLocallyInHierarchy)
            LocalFixedUpdate();
    }

    // Update is called once per frame
    void LocalFixedUpdate() {
        OVRInput.FixedUpdate();
        bool VRThumb = VRContollerInput();
        if (!VRThumb) {
            //print("running keybaord input");
            KeyboardInput();
        }
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        
        rb.AddForce(movement * speed);

    }

    void LocalUpdate() {
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

    bool VRContollerInput() {
        // returns a Vector2 of the primary (typically the Left) thumbstick’s current state.
        // (X/Y range of -1.0f to 1.0f)
        var tempLeft = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        var tempRight = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        bool thumbStick = false;
        //countText.text = tempLeft.ToString();
        if (tempLeft != new Vector2(0f,0f)) {
            LeftStick = (tempLeft);
            movementX = tempLeft.x;
            movementY = tempLeft.y;
            thumbStick = true;
        }
        else if (tempRight != new Vector2(0f, 0f)) {
            movementX = tempRight.x;
            movementY = tempRight.y;
            thumbStick = true;
        }
        //print(thumbStick);
        return thumbStick;
    }
    
    void KeyboardInput() {
        var tempFB = 0f;
        var tempLR = 0f;
        
        if (Input.GetKey(KeyCode.W)) {
            tempFB += 1;
            //Debug.Log("W");
        }
        if (Input.GetKey(KeyCode.S)) {
            tempFB -= 1;
           // Debug.Log("S");
        }
        if (Input.GetKey(KeyCode.A)) {
            tempLR -= 1;
            //Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.D)) {
            tempLR += 1;
            //Debug.Log("D");
        }
        //print(tempFB);
        //print(tempLR);
        movementX = tempLR;
        movementY = tempFB;
    }

}
