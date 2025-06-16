using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDialogue : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;
    [SerializeField] private DialogueObject dialogueObject;

    public DialogueUI DialogueUI => dialogueUI;
    void Start()
    {
        DialogueUI.ShowDialogue(dialogueObject);
    }    
}

