using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WaitForVideoEnd : MonoBehaviour
{
    public GameObject skipButton;
    private void Start()
    {
        StartCoroutine(SkipVideo(5));
    }

    IEnumerator SkipVideo(float delay)
    {
        yield return new WaitForSeconds(delay);
        skipButton.SetActive(true);
    }
}
