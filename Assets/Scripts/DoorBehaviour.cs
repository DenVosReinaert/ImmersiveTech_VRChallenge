using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public Rigidbody doorRb;
    private Vector3 doorRotation;

    void Start()
    {
        doorRb = this.gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        doorRotation = new Vector3 (0, Mathf.Clamp(doorRb.gameObject.transform.rotation.y, -90f, 90f), 0);
        doorRb.gameObject.transform.localEulerAngles = doorRotation;
    }
}
