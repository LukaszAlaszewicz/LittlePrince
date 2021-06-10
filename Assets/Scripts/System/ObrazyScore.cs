using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObrazyScore : MonoBehaviour
{
    public static int theScore;
    public GameObject teleport;
    public GameObject scoreText;
 
    void Update()
    {
        scoreText.GetComponent<Text>().text = " " + theScore;

        if (ObrazyScore.theScore == 3)
            teleporter();
    }

    public void teleporter()
    {
        if (ObrazyScore.theScore == 3)
        {
            teleport.SetActive(true);
            Debug.Log("Zebrano 3 punkty!");
        }
    }

    
}
