using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obroty : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

    //skrypt do obracania przedmiot�w

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }

}
