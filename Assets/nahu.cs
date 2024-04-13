using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nahu : MonoBehaviour
{

    public float speed;
    [SerializeField] Rigidbody rb;

    public Text gameOver;
    public GameObject buttonRestart;

    //ff
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody>();
        gameOver.enabled = false;
        buttonRestart.SetActive(false);
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
        }
        if (transform.position.y < -5 || transform.position.x < -21.598)
        {
            UIGameOver();
        }
    }

    void Limit()
    {
        if(transform.position.x > 0)
        {
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        }
    }
    void UIGameOver()
    {
        gameOver.enabled = true;
        buttonRestart.SetActive(true);
        Time.timeScale = 0.2f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
