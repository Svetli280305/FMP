using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRoom : MonoBehaviour
{
    [SerializeField] int sceneToLoad;

    bool active = false;

    private void Update()
    {
        if(active == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Is in trigger");
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player")
        {
            active = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            active = false;
        }
    }
}
