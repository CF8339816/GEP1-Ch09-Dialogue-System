using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

//using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    //public Text nameText;
    //public Text dialogueText;

   [SerializeField] private UIManager uiManager;
    [SerializeField] private PlayerMovementController playerMovementController;
    [SerializeField] private PlayerInteractionController playerInteractionController;


   // bool isDialogue = true;
   //// bool playerMovement.moveEnabled = false;
   //// bool playerInteraction.moveEnabled = false;

   private Queue<string> dialogueQueue;




    private void Awake()
    {
        uiManager = ServiceHub.Instance.UIManager;
        playerMovementController = ServiceHub.Instance.Player.GetComponent<PlayerMovementController>();
        playerInteractionController = ServiceHub.Instance.Player.GetComponent<PlayerInteractionController>();

    }
     //playerMovement.moveEnabled = false;
     //   playerInteraction.moveEnabled = false;
     //   isDialogue = true;
     //   Debug.Log("Starting conversation " );

     //  // sentences.Clear();
     //   dialogueQueue.Clear();
    public void StartDialogue(string[] sentences)
    {
       

       // nameText.text = dialogue.Name;

        if (dialogueQueue.Count == 1) Debug.LogError("NOPERS");

   
        foreach (string currentstring in sentences)
        {

            dialogueQueue.Enqueue(currentstring);

        }
        DisplayNextString();
    }

    public void DisplayNextString()
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
