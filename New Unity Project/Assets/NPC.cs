using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class NPC : MonoBehaviour {

    public bool Bag = false;
    public bool Passport = false;
    public bool Food = false;
    public bool Water = false;

    public Transform ChatBackGround;
    public Transform NPCCharacter;

    private DialogueSystem dialogueSystem;

    public string Name;

    [TextArea(5, 10)]
    public string[] preConditionSentences;
    [TextArea(5, 10)]
    public string[] postConditionSentences;

    void Start () {
        dialogueSystem = FindObjectOfType<DialogueSystem>();
    }
	
	void Update () {
          Vector3 Pos = Camera.main.WorldToScreenPoint(NPCCharacter.position);
          Pos.y += 175;
          ChatBackGround.position = Pos;
    }

    public void OnTriggerStay(Collider other)
    {
        this.gameObject.GetComponent<NPC>().enabled = true;
        FindObjectOfType<DialogueSystem>().EnterRangeOfNPC();
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.F))
        {
            this.gameObject.GetComponent<NPC>().enabled = true;
            dialogueSystem.Names = Name;
            if(Water)
            {
                if (PlayerInfo.hasWater)
                {
                    dialogueSystem.dialogueLines = postConditionSentences;
                }
                else
                {
                    dialogueSystem.dialogueLines = preConditionSentences;
                }
            }

            else if (Food)
            {
                if (PlayerInfo.hasFood)
                {
                    dialogueSystem.dialogueLines = postConditionSentences;
                }
                else
                {
                    dialogueSystem.dialogueLines = preConditionSentences;
                }
            }

            else if (Bag)
            {
                if (PlayerInfo.hasBag)
                {
                    dialogueSystem.dialogueLines = postConditionSentences;
                }
                else
                {
                    dialogueSystem.dialogueLines = preConditionSentences;
                }
            }
            else if (Passport)
            {
                if (PlayerInfo.hasPassport)
                {
                    dialogueSystem.dialogueLines = postConditionSentences;
                }
                else
                {
                    dialogueSystem.dialogueLines = preConditionSentences;
                }
            }
            else
            {
                dialogueSystem.dialogueLines = preConditionSentences;
            }

            FindObjectOfType<DialogueSystem>().NPCName();
        }
    }

    public void OnTriggerExit()
    {
        FindObjectOfType<DialogueSystem>().OutOfRange();
        this.gameObject.GetComponent<NPC>().enabled = false;
    }
}

