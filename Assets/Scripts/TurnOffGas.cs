using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffGas : MonoBehaviour
{
     public GameObject gasOffBtn;
    public ParticleSystem gasLeak;
    public GameObject radiationEffect;
    public AudioSource soundSource;



    void Start()
    {
        soundSource = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
             gasOffBtn.SetActive(true);
            StartCoroutine(stopLeak());
            radiationEffect.SetActive(true);
            soundSource.Play();

        }
    }

    private void OnTriggerExit(Collider other)
    {
         gasOffBtn.SetActive(false);
        radiationEffect.SetActive(false);

    }

    IEnumerator stopLeak()
    {
        yield return new WaitForSeconds(2f);
        gasLeak.GetComponent<ParticleSystem>().Stop();
        radiationEffect.SetActive(false);
        soundSource.enabled = false;
        gasOffBtn.SetActive(false);
    }

}

// this one
