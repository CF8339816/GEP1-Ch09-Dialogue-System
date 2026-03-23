using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCDialogueTrigger : MonoBehaviour, IInteractable
{

    public Dialogue dialogue;

    private DialogueManager dialogueManager;


    private void Awake()
    {
        ServiceHub.Instance.DialogueManager.StartDialogue(dialogue);

    }
    public void Interact()
    {
        dialogueManager.StartDialogue(dialogue);

    }

    //public  TriggerDialogue ()
    //{
    //    dialogueManager = ServiceHub.Instance.DialogueManager.StartDialogue(dialogue);


    //}



}
