using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsEnd : MonoBehaviour
{
    float timeInScene = 0f;

    void Update()
    {
        timeInScene += Time.deltaTime;
        if(timeInScene >= 60 || Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }
    }
}
