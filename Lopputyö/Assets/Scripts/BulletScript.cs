using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private GameManager gameManager;
    private AudioSource audioDeath;
    public ParticleSystem particleBullet;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        audioDeath = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            audioDeath.Play();
            gameManager.UpdateScore(1);           
            Destroy(collision.gameObject);            
            particleBullet.Play();
        }
        if (collision.transform.tag == "Terrain")
        {            
            Destroy(gameObject);
        }
    }
}
