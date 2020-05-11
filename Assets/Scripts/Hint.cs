using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public GameObject gb;
    public GameObject UI;
    public GameObject exit;
    public bool purple = false;
    public bool green = false;
    public bool blue = false;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            gb.SetActive(true);
            UI.SetActive(false);
            Time.timeScale = 0f;
        }
    }

    void Update()
    {
        if (green && blue && purple)
        {
            exit.SetActive(false);
        }
        else
        {
            exit.SetActive(true);
        }
    }

    public void Exit()
    {
        Time.timeScale = 1f;
        UI.SetActive(true   );
        gb.SetActive(false);
    }
}
