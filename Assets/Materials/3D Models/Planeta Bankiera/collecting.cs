using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class collecting : MonoBehaviour
{
    public float speed;
    public AudioSource clip;
    //public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            col.GetComponent<coins>().coinz++;
            clip.Play();
            Destroy(gameObject);
        }
    }
}
