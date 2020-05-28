using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private Button button;
    private SpawnEnemy spawnEnemy;

    
    
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy = GameObject.Find("SpawnEnemy").GetComponent<SpawnEnemy>();

        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ButtonStartGame()
    {
        spawnEnemy.StartGame();
    }
}
