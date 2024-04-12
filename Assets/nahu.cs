using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nahu : MonoBehaviour
{

    public float speed;
    [SerializeField] Rigidbody rb;
    bool limitX;
    bool LimitXN;


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
            Limit();
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(-speed, 0f, 0f), ForceMode.Acceleration);
            Limit();
        }
        if (transform.position.y < -2)
        {
            SceneManager.LoadScene(0);
        }
    }
    void Limit()
    {
        if(transform.position.x < -14.96)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > -8.69)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
