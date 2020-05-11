using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FancyColor : MonoBehaviour
{
    public TextMeshProUGUI img;
    private string first = "fir";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        img.color = Color.Lerp(Color.red, Color.green, Mathf.PingPong(Time.time, 1));

    }
}
