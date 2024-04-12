using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovePlataform : MonoBehaviour
{

    public float speed;
    [SerializeField] SpawnPlataform spawnPlataform;
    bool spawnPlataformAble;

    // Start is called before the first frame update
    void Start()
    {
        spawnPlataform = GameObject.Find("SpawnPlataformPoint").GetComponent<SpawnPlataform>();

    }
    void Awake()
    {
        spawnPlataformAble = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -1 && spawnPlataformAble)
        {
            SendSpawnMessage();
            spawnPlataformAble = false;
            Debug.Log("spawn");
        }
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }

    void SendSpawnMessage()
    {
        spawnPlataform.SpawnPlataforms();
    }
}
