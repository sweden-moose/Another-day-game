using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riddle : MonoBehaviour
{
    public string tags;
    public Hint hint;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == tags)
        {
            if (tags == "green")
            {
                hint.green = true;
            }
            else if (tags == "purple")
            {
                hint.purple = true;
            }
            else if (tags == "blue")
            {
                hint.blue = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == tags)
        {
            if (tags == "green")
            {
                hint.green = false;
            }
            else if (tags == "purple")
            {
                hint.purple = false;
            }
            else if (tags == "blue")
            {
                hint.blue = false;
            }
        }
    }

}
