using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAxisValue;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxisValue * Time.deltaTime);
    }
}
