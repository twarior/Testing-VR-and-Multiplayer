using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class NormcorePlayer : MonoBehaviour {
    // Camera
    public Transform cameraTarget;
    private float _mouseLookX;
    private float _mouseLookY;

    // Physics
    private Vector3 _targetMovement;
    private Vector3 _movement;

    private Rigidbody _rigidbody;

    // Multiplayer
    private RealtimeView _realtimeView;

    private void Awake() {
        // Set physics timestep to 60hz
        Time.fixedDeltaTime = 1.0f / 60.0f;

        // Store a reference to the rigidbody for easy access
        _rigidbody = GetComponent<Rigidbody>();

        // Store a reference to the RealtimeView for easy access
        _realtimeView = GetComponent<RealtimeView>();
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


    private void LocalUpdate() {
        // Move the camera using the mouse
        RotateCamera();

        // Use WASD input and the camera look direction to calculate the movement target
        CalculateTargetMovement();

    }

    private void LocalFixedUpdate() {
        // Move the player based on the input
        MovePlayer();

        
    }


    private void RotateCamera() {
        // Get the latest mouse movement. Multiple by 4.0 to increase sensitivity.
        _mouseLookX += Input.GetAxis("Mouse X") * 4.0f;
        _mouseLookY += Input.GetAxis("Mouse Y") * 4.0f;

        // Clamp how far you can look up + down
        while (_mouseLookY < -180.0f) _mouseLookY += 360.0f;
        while (_mouseLookY > 180.0f) _mouseLookY -= 360.0f;
        _mouseLookY = Mathf.Clamp(_mouseLookY, -15.0f, 15.0f);

        // Rotate camera
        cameraTarget.localRotation = Quaternion.Euler(-_mouseLookY, _mouseLookX, 0.0f);
    }

    private void CalculateTargetMovement() {
        // Get input movement. Multiple by 6.0 to increase speed.
        Vector3 inputMovement = new Vector3();
        inputMovement.x = Input.GetAxisRaw("Horizontal") * 6.0f;
        inputMovement.z = Input.GetAxisRaw("Vertical") * 6.0f;
        _targetMovement = inputMovement;


        // Get the direction the camera is looking parallel to the ground plane.
        Vector3 cameraLookForwardVector = ProjectVectorOntoGroundPlane(cameraTarget.forward);
        Quaternion cameraLookForward = Quaternion.LookRotation(cameraLookForwardVector);

        // Use the camera look direction to convert the input movement from camera space to world space
        _targetMovement = cameraLookForward * inputMovement;
    }

    private void MovePlayer() {
        // Start with the current velocity
        Vector3 velocity = _rigidbody.velocity;

        // Smoothly animate towards the target movement velocity
        _movement = Vector3.Lerp(_movement, _targetMovement, Time.fixedDeltaTime * 5.0f);
        velocity.x = _movement.x;
        velocity.z = _movement.z;

        // Set the velocity on the rigidbody
        _rigidbody.velocity = velocity;  
    }

    private static Vector3 ProjectVectorOntoGroundPlane(Vector3 vector) {
        Vector3 planeNormal = Vector3.up;
        Vector3.OrthoNormalize(ref planeNormal, ref vector);
        return vector;
    }
}
