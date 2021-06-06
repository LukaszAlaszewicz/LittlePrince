using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LP
{
    public class CustomCursor : MonoBehaviour
    {
        public Texture2D cursorTexture;
        public CursorMode cursorMode = CursorMode.ForceSoftware;
        public Vector2 hotSpot = Vector2.zero;
        void Start()
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }

        // Update is called once per frame
        void Update()
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                Cursor.visible = true;
            }
            else if (Time.timeScale == 0)
            {
                Cursor.visible = true;
            }
            else
            {
                Cursor.visible = false;
            }
        }
    }

}