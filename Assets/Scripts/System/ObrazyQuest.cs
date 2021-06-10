using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//By Julia Duda
public class ObrazyQuest : MonoBehaviour
{
    public static int theScore;
    public AudioSource collectSound;
    public GameObject done;
    public GameObject teleport;
    private GameObject score;

    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ObrazyScore.theScore += 1;
        done.GetComponent<BoxCollider>().enabled = false;
    }



}
