using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguestartNovel : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;

    public DialogueUI DialogueUI => dialogueUI;

    public IInteractable Interactable { get; set; }
    void Start()
    {
        //DialogueUI.ShowDialogue(dialogueObject);
    }

    void Update()
    {
        
    }
}
