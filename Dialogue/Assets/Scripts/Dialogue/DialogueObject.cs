using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]

public class DialogueObject : ScriptableObject
{
    [SerializeField] [TextArea] private string[] dialogue;
    [SerializeField] private Response[] responses;

    [SerializeField] [TextArea] private string[] speaking;

    public string[] Dialogue => dialogue; //Code from the outsite can only read not change the text from the dialogue

    public bool HasResponses => Responses != null && Responses.Length > 0;
    public Response[] Responses => responses;

    public string[] Speaking => speaking;
}
