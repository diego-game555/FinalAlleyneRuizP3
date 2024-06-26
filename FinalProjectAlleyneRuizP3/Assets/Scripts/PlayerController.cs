using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.SceneView;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float rotationSpeed;
    public Attack attack;

    private GameObject hitrange = default;
    private bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 0f;

    private Rigidbody rb;

    [SerializeField]
    private Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        hitrange = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitiude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * movementDirection;
        movementDirection.Normalize();

        characterController.SimpleMove(movementDirection * magnitiude);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }

        if (attacking)
        {
            timer += Time.deltaTime;

            if(timer >- timeToAttack)
            {
                timer = 0;
                attacking = false;
                hitrange.SetActive(attacking);
            }
        }

    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void Attack()
    {
        attacking = true;
        hitrange.SetActive(attacking);
    }

    

    private void This()
    {
      
    }
}