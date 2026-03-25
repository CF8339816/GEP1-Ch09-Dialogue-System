using UnityEngine;

public class interactableDialogue : MonoBehaviour, IInteractable
{
    [Header("Dialogue")]
    [SerializeField] private string dialogue;

    [SerializeField] private UIManager uiManager;
    [SerializeField] private DialogueManager dialogueManager;

    private void Awake()
    {
        dialogueManager = ServiceHub.Instance.DialogueManager;
       uiManager = ServiceHub.Instance.UIManager;

        if (uiManager == null) Debug.LogError("UIManager not found in ServiceHub. Please ensure it is properly set up.");
    }


    public void Interact()
    { 

        if (dialogueManager.inDialogue= true)
        {
            dialogueManager.DisplayNextString();

        }

        else
        {
            dialogueManager.StartDialogue(dialogueQueue);

        }

    }
}
