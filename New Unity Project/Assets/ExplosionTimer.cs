using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplosionTimer : MonoBehaviour
{
    float timeInScene = 0f;

    void Update()
    {
        timeInScene += Time.deltaTime;
        if(timeInScene >= 1)
        {
            SceneManager.LoadScene(3);
        }
    }
}
