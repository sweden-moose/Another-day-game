using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevel : MonoBehaviour
{
    public GameObject sc;
    private BoxCollider2D bc;
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            SceneChanger fg = sc.GetComponent<SceneChanger>();
            fg.change(name);
        }
    }
}
