using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tut : MonoBehaviour
{
    public GameObject image;
    private bool was = true;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (was && col.tag == "Player")
        {
            image.SetActive(true);
            was = false;
            Time.timeScale = 0f;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Time.timeScale = 0f;
        }
    }

    public void back()
    {
        Debug.Log("Stop");
        Time.timeScale = 1f;
        image.SetActive(false);
        gameObject.SetActive(false);
    }
}
