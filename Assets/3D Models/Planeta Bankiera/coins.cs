using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    private GUIStyle guiStyle = new GUIStyle();
    public int coinz = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        guiStyle.fontSize = 30;
        //guiStyle.color = white;
        guiStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(30, 30, 200, 20), "Zebrane monety: " + coinz, guiStyle);
    }
}
