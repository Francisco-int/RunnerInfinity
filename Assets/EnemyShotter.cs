using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotter : MonoBehaviour
{
    public GameObject bala;
    public float shotCoolDown;
    public Transform shotPoint;
    public float balaForce;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shot", shotCoolDown, shotCoolDown);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Shot()
    {
        GameObject newBala = Instantiate(bala, shotPoint);
        Rigidbody rb = newBala.GetComponent<Rigidbody>();
        rb.AddForce(newBala.transform.up * balaForce, ForceMode.Impulse);
        Debug.Log("Shot");
    }
}
