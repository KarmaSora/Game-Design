using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    //changed to private as we dont needthem anymore
    private float carSpeedMultiplier = 90.0f;
    private float turnSpeed = 25.0f;

    private float horizontalInput;      //Set to private as they are handled  automaticly, can change to public but unneccecery
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Player Input
        horizontalInput = Input.GetAxis("Horizontal");  // horizontal = left and right
        verticalInput = Input.GetAxis("Vertical"); //Vertical means  up and down


        //Make Player Move and Rotate
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeedMultiplier * verticalInput);

        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);  // moves the player sideways
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput *Time.deltaTime);  // makes the player rotate


    }
}
