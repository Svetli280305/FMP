using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource[] controlledSources;
    void FixedUpdate()
    {
        foreach (AudioSource source in controlledSources)
        {
            source.volume = PlayerPrefs.GetFloat("Volume");
        }
    }
}
