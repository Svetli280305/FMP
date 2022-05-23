using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusBlock : MonoBehaviour
{
    PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("First Person Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.hasPassport)
        {
            Destroy(GetComponent<BoxCollider>());
        }
    }
}
