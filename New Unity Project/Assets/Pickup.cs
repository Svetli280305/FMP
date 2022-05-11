using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool outOfRange = true;
    public PlayerMovement pm;
    public GameObject doorGUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pm.bag){
            pm.bag.SetActive(false);
        }
        if(pm.passport){
            pm.passport.SetActive(false);
        }
        if (pm.food)
        {
            pm.food.SetActive(false);
        }
        if (pm.water)
        {
            pm.water.SetActive(false);
        }
    }

    void OnTriggerStay(Collider coll)
    {
        if(coll.CompareTag("Player"))
        {
            doorGUI.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E) && gameObject.CompareTag("Bag"))
            {
                pm.bag = gameObject;
                pm.hasBag = true;
                
            }
            if(Input.GetKeyDown(KeyCode.E) && gameObject.CompareTag("Passport"))
            {
                pm.passport = gameObject;
                pm.hasPassport = true;
                
            }
            if (Input.GetKeyDown(KeyCode.E) && gameObject.CompareTag("Food"))
            {
                pm.food = gameObject;
                pm.hasFood = true;

            }
            if (Input.GetKeyDown(KeyCode.E) && gameObject.CompareTag("Water"))
            {
                pm.water = gameObject;
                pm.hasWater = true;

            }
        }
    }
    
    void OnDisable()
    {
        doorGUI.SetActive(false);
    }

    void OnTriggerExit(Collider coll)
    {
        if(coll.CompareTag("Player"))
        {
            doorGUI.SetActive(false);
        }
    }
}
