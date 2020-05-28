using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;

    private float delayTime = 1.0f;
    private float counter = 0;
    private AudioSource audioShoot;

    // Start is called before the first frame update
    void Start()
    {
        audioShoot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && counter > delayTime)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            counter = 0;
            audioShoot.Play();
        }
        counter += Time.deltaTime;
    }
}
