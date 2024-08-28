using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    private float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        var deltaTime = Time.deltaTime;

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        var rotation = -Vector3.right * (verticalInput * rotationSpeed);
        transform.Rotate( rotation * deltaTime);
    }
}