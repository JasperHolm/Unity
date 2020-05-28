using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButtn;
    public GameObject titlescreen;

    private AudioSource audioMusic;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        audioMusic = GetComponent<AudioSource>();

        isGameActive = true;
        
        score = 0;
        UpdateScore(0);

        audioMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        restartButtn.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        audioMusic.Stop();
    }
    public void RestartGame()
    {       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
