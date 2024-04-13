using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int plataformsPassed;
    public Text uiPlataforms;
    public GameObject shotters;

    // Start is called before the first frame update
    void Start()
    {
        shotters.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlataformsPassed()
    {
        plataformsPassed++;
        uiPlataforms.text =  "Plataforms passed: " + plataformsPassed.ToString();
        if(plataformsPassed >= 5) 
        {
            SpawnShotter();
        }
    }
    void SpawnShotter()
    {
        shotters.SetActive(true);
    }
    public void StarGame()
    {
        SceneManager.LoadScene(1);
    }
}
