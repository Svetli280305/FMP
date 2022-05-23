using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplosionTimer : MonoBehaviour
{
    public float time = 1.0f;
    float timeInScene = 0f;

    void Update()
    {
        timeInScene += Time.deltaTime;
        if(timeInScene >= time)
        {
            SceneManager.LoadScene(3);
        }
    }
}
