using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public string npcName;
    public DialogMenager dialogMenager;
    public List<string> npcConvo = new List<string>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogMenager.Start_Dialog(npcName, npcConvo);
        }
    }

}
