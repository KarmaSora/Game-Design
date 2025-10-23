using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    public float carSpeedMultiplier = 90.0f;
    public float turnSpeed = 15.0f;

    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");  // horizontal = left and right
        verticalInput = Input.GetAxis("Vertical"); //Vertical means  up and down


        transform.Translate(Vector3.forward * Time.deltaTime * carSpeedMultiplier * verticalInput);


        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);  // moves the player sideways
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput *Time.deltaTime);  // makes the player rotate


    }
}
