using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPCTalking : MonoBehaviour
{
    public TextMeshProUGUI nameTag;
    public TextMeshProUGUI mainConverstion;

    public Animator animator;

    //dialogue manager
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

   public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true); //Move the Game UI onto screen
        Debug.Log("Start Dialogue with " + dialogue.name); //gives debug messagew 
        sentences.Clear(); //remove all sentence from other NPC

        nameTag.text = dialogue.name;

        foreach (string sentence in dialogue.sentences)
        { sentences.Enqueue(sentence); //Display each sentecne letter by letter

        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() //Founds next sentence and display it same way as before
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        //mainConverstion.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }


    IEnumerator TypeSentence (string sentence)
    {
        mainConverstion.text = "";
        foreach (char letter in sentence.ToCharArray()) //adds each letter in one by one 
        {
            mainConverstion.text += letter; //adds a wait to make the text look like it being written
            yield return null;
        }
    }
    public void EndDialogue()
    {
        Debug.Log("End OF Dialogue"); 
        animator.SetBool("IsOpen", false); //Move UI off screen after finsished talking
    }
}
