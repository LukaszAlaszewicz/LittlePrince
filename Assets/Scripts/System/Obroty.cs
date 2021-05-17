using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obroty : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

    //skrypt do obracania przedmiotów

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }

}
