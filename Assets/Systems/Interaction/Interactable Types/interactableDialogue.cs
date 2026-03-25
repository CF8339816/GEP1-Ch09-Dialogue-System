using UnityEngine;

public class interactableDialogue : MonoBehaviour, IInteractable
{
   
    [SerializeField] private DialogueManager dialogueManager;
    
    
    
    [Header("Dialogue")]
   
   // public string Name;
    [TextArea(3, 10)] public string[] sentences;

    //[SerializeField] private UIManager uiManager;
     //[SerializeField] private string dialogue;

    private void Awake()
    {
        dialogueManager = ServiceHub.Instance.DialogueManager;
        //uiManager = ServiceHub.Instance.UIManager;

        //if (uiManager == null) Debug.LogError("UIManager not found in ServiceHub. Please ensure it is properly set up.");
    }


    public void Interact()
    { 

        //if (dialogueManager.inDialogue= true)
        //{
        //    dialogueManager.DisplayNextString();

        //}

        //else
        //{
            dialogueManager.StartDialogue(sentences);

        //}

    }
}
