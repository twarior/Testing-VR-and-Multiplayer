using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour {

    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    private int cubesPickedUp;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start() {
        //grabs the rigidbody component from the player sphere
        rb = GetComponent<Rigidbody>();

        cubesPickedUp = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate() {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
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

        if(cubesPickedUp >= 12) {
            winTextObject.SetActive(true);
        }
    }

}
