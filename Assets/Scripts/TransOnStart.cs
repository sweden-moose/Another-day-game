using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransOnStart : MonoBehaviour
{
    public Animator trasitions;
    public Animator aud;
    public GameObject image;
    private bool was = true;
    // Start is called before the first frame update
    IEnumerator Stert()
    {
        try { aud.SetTrigger("start"); } catch { }
            
            trasitions.SetTrigger("start");
            yield return new WaitForSeconds(2.0f);
        try
        {
            aud.SetTrigger("idle");
        }
        catch
        {

        }
            was = false;
            image.transform.localScale = new Vector3(0f, 0f, 0f);
            
    }

    // Update is called once per frame
    void Update()
    {
        if (was)
        {
            StartCoroutine(Stert());
        }
    }
}
