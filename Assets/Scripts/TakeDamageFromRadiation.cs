using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageFromRadiation : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject radiationEffect;
    public AudioSource soundSource;

    void Start()
    {
        soundSource = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(8);
            soundSource.Play();

        }
    }

    void TurnOffSound()
    {
        soundSource.enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(8);
            TurnOffSound();
            radiationEffect.SetActive(false);
        }

    }
}
