using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWithAsset : MonoBehaviour
{




    //From Dapper Dino's New Unity INPUT SYSTEM tutorial


    [SerializeField] private float movementSpeed = 20f;
    private Controls controls = null;

    private void Awake() {
        controls.PLayer.Enable();
    }

    private void OnEnable() {
        controls.PLayer.Enable();
    }

    private void OnDisable() {
        controls.PLayer.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    private void Move() {

        var movementInput = controls.PLayer.Movement.ReadValue<Vector2>();

        var movement = new Vector3 {
            x = movementInput.x,
            z = movementInput.y
        };

        movement.Normalize();

        transform.Translate(movement * movementSpeed * Time.deltaTime);
        
    }
}
