using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThomasTrigger : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) //Trigger used to call my dialogue function when player gets close to any NPC
        {
            dialogueTrigger.TriggerDialogue();
        }
    }
}
