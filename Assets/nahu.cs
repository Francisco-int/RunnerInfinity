using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nahu : MonoBehaviour
{

    public float speed;
    public float pullForce;
    [SerializeField] Rigidbody rb;

    public Text gameOver;
    public GameObject buttonRestart;

    public Material transparent;
    public Material normal;
    public Renderer playerRenderer;
    public MeshRenderer playerMeshRenderer;

    bool controls;
    bool moveAble;
   
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody>();
        gameOver.enabled = false;
        playerRenderer = GetComponent<Renderer>();
        playerMeshRenderer = GetComponent<MeshRenderer>();
        buttonRestart.SetActive(false);
        controls = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-pullForce * Time.deltaTime, 0, 0));
        //rb.AddForce(new Vector3(-pullForce, 0f, 0f));
        if (controls)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector3(0f, 0f, speed));
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector3(0f, 0f, -speed));
            }
            if (moveAble)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    rb.AddForce(new Vector3(speed, 0f, 0f));
                }
                if (Input.GetKey(KeyCode.S))
                {
                    rb.AddForce(new Vector3(-speed, 0f, 0f));
                }
            }
        }
        
        if(transform.position.x < -16.69)
        {
            controls = false;
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector3(0f, 0f, speed));
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector3(0f, 0f, -speed));
            }
            if (moveAble)
            {
                if (Input.GetKey(KeyCode.S))
                {
                    rb.AddForce(new Vector3(speed, 0f, 0f));
                }
                if (Input.GetKey(KeyCode.W))
                {
                    rb.AddForce(new Vector3(-speed, 0f, 0f));
                }
            }
        }
        else
        {
            controls = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            moveAble = false;
            playerRenderer.material = transparent;
            playerMeshRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        }
        else
        {
            moveAble = true;
            playerRenderer.material = normal;
            playerMeshRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }
        if (transform.position.y < -5 || transform.position.x < -21.598)
        {
            UIGameOver();
        }
        if (transform.position.x > -8)
        {
            transform.position = new Vector3(-8f, transform.position.y, transform.position.z);
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
