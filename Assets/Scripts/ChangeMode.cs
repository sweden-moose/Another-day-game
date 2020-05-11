using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeMode : MonoBehaviour
{
    public GameObject txt;
    private string mode = "light";
    private TextMeshProUGUI text;

    void Start()
    {
         text = txt.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (mode == "light")
            {
                text.text = "Control";
                mode = "control";
            }
            else
            {
                text.text = "Flashlight";
                mode = "light";
            }

        }
    }
}
