using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    private UIManager uiManager;
    private PlayerMovementController playerMovementController;
    private PlayerInteractionController playerInteractionController;
    bool isDialogue = true;
   // bool playerMovement.moveEnabled = false;
   // bool playerInteraction.moveEnabled = false;

    private Queue<string> dialogueQueue;
  void Start()
    {
        dialogueQueue = new Queue<string>();
        
    }
    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.Name );

        nameText.text = dialogue.Name;

        isDialogue = true;
       // playerMovement.moveEnabled = false;
       // playerInteraction.moveEnabled = false;

        dialogueQueue.Clear();

        foreach(string sentence in dialogue.dialogueQueue)
        {

            dialogueQueue.Enqueue(sentence);

        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (dialogueQueue.Count==0)
        {
            EndDialogue();
            return;

        }
        else if(dialogueQueue.Count>0)
        {
            uiManager.setDialogueQueue = dialogueQueue.Dequeue();
        }
            string sentence = dialogueQueue.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);
    }

   void EndDialogue()
    {
        Debug.Log("end of conversation.");


        dialogueQueue.Clear();

        uiManager.HideDialoguePanel();
        isDialogue = false;
       // playerMovement.moveEnabled = true;
       // playerInteraction.moveEnabled = true;

    }
}
