using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarrels : MonoBehaviour
{
    //public GameObject gasOffBtn;
    public GameObject radiationEffect;
    public GameObject spill;
    public AudioSource soundSource;

    void Start()
    {
        soundSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            StartCoroutine(stopLeak());
            soundSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {

    }

    IEnumerator stopLeak()
    {
        yield return new WaitForSeconds(2f);
        Destroy(spill);
        radiationEffect.SetActive(false);
        soundSource.enabled = false;

    }
}

// this one