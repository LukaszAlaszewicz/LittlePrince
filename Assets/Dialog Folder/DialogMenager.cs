using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//by julia duda
public class DialogMenager : MonoBehaviour
{
    public GameObject DialogPanel;
    public TMP_Text npcNameText;
    public TMP_Text dialogText;
    public Button NextButton;
    public GameObject StopTheDialog;
  
    /*
     Skrypt odpwoedzialny za dialogi w grze
         
         */


    private List<string> conversation;
    private int convoIndex;

    private void Start()
    {
        DialogPanel.SetActive(false);
    }

    public void Start_Dialog(string _npcName, List<string> _convo)
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        npcNameText.text = _npcName;
        conversation = new List<string>(_convo);
        DialogPanel.SetActive(true);
        convoIndex = 0;
        ShowText();
        Time.timeScale = 0;


    }

    public void StopDialog()
    {
        Cursor.visible = false;
        DialogPanel.SetActive(false);
        Time.timeScale = 1;
        StopTheDialog.GetComponent<BoxCollider>().enabled = false;

    }

    private void ShowText()
    {
        dialogText.text = conversation[convoIndex];
    }

    public void Next()
    {
        if (convoIndex < conversation.Count - 1)
        {
            convoIndex += 1;
            ShowText();
            Debug.Log("Next Button pressed");
        }

    }
}
