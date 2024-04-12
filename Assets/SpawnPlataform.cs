using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataform : MonoBehaviour
{


    public List<GameObject> plataform;
    public Transform spawnPoint;
    int randomPlataformSelect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlataforms()
    {
        randomPlataformSelect = Random.Range(0, plataform.Count);
        Instantiate(plataform[randomPlataformSelect], spawnPoint);
    }
}
