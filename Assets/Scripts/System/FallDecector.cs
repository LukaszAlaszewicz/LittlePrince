using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//by julia duda

public class FallDecector : MonoBehaviour
{
    //dodaje cheakpoint, który ma zapisan¹ pozycje starow¹ Playera
    Vector3 cheakpoint;
    void Start()
    {
        cheakpoint = new Vector3(-10, 2, 3);
    }

    // Update is called once per frame

    //tworze warunek: je¿eli pozycja y playera bêdzie ni¿sza ni¿ -5 ma ona nas przemieœciæ do cheakpointu;
    void Update()
    {
        if (transform.position.y < -5)
        {
            transform.position = cheakpoint;
        }

    }
}
