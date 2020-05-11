using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_enter : MonoBehaviour
{
    public GameObject destroy;
    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        destroy.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D col)
    {
        destroy.SetActive(false);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        destroy.SetActive(true);
    }

}
