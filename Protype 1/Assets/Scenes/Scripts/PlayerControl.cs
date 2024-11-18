using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horzontailInput;
    private float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get PlayerInput
        horzontailInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We Move the Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We Turn the Vehicle
        transform.Rotate(Vector3.up, turnSpeed * horzontailInput *  Time.deltaTime);

    }
}
