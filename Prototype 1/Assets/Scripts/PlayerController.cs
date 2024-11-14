using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 9.0f;
    private float turnSpeed=35.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Moves the vehicle forward based on up/down input
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        //Turns the vehicle based on left/right input
        transform.Rotate(Vector3.up,turnSpeed*horizontalInput*Time.deltaTime);
    }
}
