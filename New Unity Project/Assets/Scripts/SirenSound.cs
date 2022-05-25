using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SirenSound : MonoBehaviour
{
    float timeInScene = 0f;
    [SerializeField] AudioSource sirenSource;
    [SerializeField] AudioClip sirenClip;

    void Update()
    {
        timeInScene += Time.deltaTime;
        if (timeInScene >= 5.0f || Input.GetKeyDown(KeyCode.Return))
        {
            sirenSource.volume = 1.0f;
            sirenSource.PlayOneShot(sirenClip);
        }
    }
}
