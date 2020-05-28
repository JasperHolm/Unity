using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private AudioSource audioPlayerDeath;
    private GameManager gameManager;
    public ParticleSystem particleSpawn;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        audioPlayerDeath = GetComponent<AudioSource>();

        particleSpawn.Play();
    }

    // Update is called once per frame
    void Update()
    {
        particleSpawn.Play();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            gameManager.GameOver();
            audioPlayerDeath.Play();
            Destroy(collision.gameObject);
            particleSpawn.Play();
        }
    }
}
