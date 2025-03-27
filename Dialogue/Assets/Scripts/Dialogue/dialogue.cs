using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class dialogue : MonoBehaviour
{
    //UI
    [SerializeField]
    private TMP_Text CharacterName;
    [SerializeField]
    private TMP_Text NPCName;
    [SerializeField]
    private TMP_Text CharacterText;
    [SerializeField]
    private TMP_Text NPCText;
    [SerializeField]
    private Image Character;
    [SerializeField]
    private Image NPC;

    //Dialogue content
    [SerializeField]
    private string[] Speaker;
    [SerializeField]
    [TextArea]
    private string[] DialogueSentences;
    [SerializeField]
    private Sprite[] portrait;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CharacterText.text = Speaker[0];
            NPCText.text = Speaker[0];
        }
    }
}
