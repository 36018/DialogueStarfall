using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]

public class DialogueObject : ScriptableObject
{
    [SerializeField] [TextArea] private string[] dialogue;

    public string[] Dialogue => dialogue; //Code from the outsite can only read not change the text from the dialogue
}
