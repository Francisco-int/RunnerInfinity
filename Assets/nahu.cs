using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nahu : MonoBehaviour
{

    public float speed;
    [SerializeField] Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(0f, 0f, speed), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0f, 0f, -speed), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(speed, 0f, 0f), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(-speed, 0f, 0f), ForceMode.Acceleration);
        }
        if (transform.position.x < -0.30)
        {
            SceneManager.LoadScene(0);
        }
    }
}
