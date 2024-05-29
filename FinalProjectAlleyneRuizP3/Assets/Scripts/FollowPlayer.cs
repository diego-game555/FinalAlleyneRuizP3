using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private const float YMin = -50.0f;
    private const float YMax = 50.0f;

    public Transform lookAt;
    public Transform Player;

    public float distance = 10.0f;
    public float currentX = 5.0f;
    public float currentY = 5.0f;
    public float sensitivity = 4.0f;

    public float deltaRotation;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        deltaRotation += Input.GetAxis("Mouse X");
        rb.MoveRotation(Quaternion.Euler(0, deltaRotation, 0));
    }

    private void LateUpdate()
    {
    }
}
