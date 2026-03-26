using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;


//using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    
   [SerializeField] private UIManager uiManager;
    [SerializeField] private PlayerMovementController playerMovement;
    [SerializeField] private PlayerInteractionController playerInteraction;
    public bool isDialogue = false;
   //// bool playerMovement.moveEnabled = false;
   //// bool playerInteraction.moveEnabled = false;

   private Queue<string> dialogueQueue;




    private void Awake()
    {
        uiManager = ServiceHub.Instance.UIManager;
        playerMovement = ServiceHub.Instance.Player.GetComponent<PlayerMovementController>();
        playerInteraction = ServiceHub.Instance.Player.GetComponent<PlayerInteractionController>();
        dialogueQueue = new Queue<string>();
    }
   
     //   Debug.Log("Starting conversation " );

     //  // sentences.Clear();
     //   dialogueQueue.Clear();
    public void StartDialogue(string[] sentences)
    { 
        
        isDialogue = true;
        playerMovement.moveEnabled = false;
       // playerInteraction.ineract
        

        uiManager.ShowDialoguePanel();
     

        foreach (string currentstring in sentences)
        {

            dialogueQueue.Enqueue(currentstring);

        }
        DisplayNextString();
    }

    public void DisplayNextString()
    {
       
        
        //if (uiManager.IsTypewriterActive())
        //{
        //    uiManager.SkipTypewriter();
        //    return;
        //}

        if (dialogueQueue.Count == 0)
        {
            EndDialogue();
            return;

        }
        else if (dialogueQueue.Count > 0)
        {
            uiManager.SetDialogueText(dialogueQueue.Dequeue());

            
        }
        
    }

   void EndDialogue()
    {
       
       // canAdvanceDialogue = false; 

        dialogueQueue.Clear();
        uiManager.HideDialoguePanel();
      
        isDialogue = false;
        playerMovement.moveEnabled = true;
        //playerInteraction. interrrrrrrr = true;

    }
}
