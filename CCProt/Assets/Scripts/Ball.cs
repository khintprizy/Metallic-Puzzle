using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Parentable"))
        {
            transform.parent = collision.transform;
        }


        if (collision.gameObject.GetComponent<Cup>())
        {
            GameObject _cup = collision.gameObject;
            _cup.GetComponent<Cup>().ballCount++;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Parentable"))
        {
            transform.parent = null;
        }


        if (collision.gameObject.GetComponent<Cup>())
        {
            GameObject _cup = collision.gameObject;
            _cup.GetComponent<Cup>().ballCount--;
        }

    }
}


