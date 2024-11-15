using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed;
    public float horzontailInput;
    public float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horzontailInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We'll Move the Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horzontailInput);
    }
}
