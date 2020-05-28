using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    private GameManager gameManager;
    private int xPos;
    private int zPos;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();      
    }
    IEnumerator EnemyDrop()
    {
        while (gameManager.isGameActive)
        {
            xPos = Random.Range(-32, 32);
            zPos = Random.Range(-32, 32);
            Instantiate(Enemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
            
        }
    }
    public void StartGame()
    {
        gameManager.isGameActive = true;
        StartCoroutine(EnemyDrop());

        gameManager.titlescreen.gameObject.SetActive(false);
    }
}
