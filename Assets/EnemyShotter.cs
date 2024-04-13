using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotter : MonoBehaviour
{
    public GameObject bala;
    public float shotCoolDown;
    public Transform shotPoint;
    public float balaForce;
    bool shot;

    // Start is called before the first frame update
    void Start()
    {
        shot = false;   
        InvokeRepeating("Shot", shotCoolDown, shotCoolDown);
    }

    private void OnEnable()
    {
        shot = true;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    void Shot()
    {
        if (shot)
        {
            GameObject newBala = Instantiate(bala, shotPoint);
            Rigidbody rb = newBala.GetComponent<Rigidbody>();
            rb.AddForce(newBala.transform.up * balaForce, ForceMode.Impulse);
            Debug.Log("Shot");
        }      
    }
}
