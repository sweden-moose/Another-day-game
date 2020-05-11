using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerFollow : MonoBehaviour
{
    public GameObject cursor;
    public GameObject player;
    public float smoothing;   
    public bool follow;
    public Animator anim;
    private MouseController mouse;
    private Vector3 point;
    private bool gotopoint = false;
    private bool canmove;
    // Start is called before the first frame update
    void Start()
    {
        mouse = cursor.GetComponent<MouseController>();
    }
    


  
        // Update is called once per frame
        void Update()
        {
        //Debug.Log(Vector3.Distance(player.transform.position, transform.position));
        if (follow)
        {
            if (Vector3.Distance(player.transform.position, transform.position) > 2.5f)
            {
                transform.position = Vector3.Lerp(transform.position, player.transform.position, smoothing * Time.deltaTime);
                anim.StopPlayback();
                Debug.Log("follow");
                anim.SetTrigger("follow");
            }
            else
            {
                Debug.Log("stop");
                anim.SetTrigger("stop");
            }
        }
        else if (gotopoint)
        {
            if (Vector3.Distance(point, transform.position) > 0.1f)
            {
                transform.position = Vector3.Lerp(transform.position, point, smoothing * 2 * Time.deltaTime);
                anim.SetTrigger("follow");
                Debug.Log("to pos");
            }
            else
            {
                gotopoint = false;
                canmove = false;
                Debug.Log("on pos");
                anim.SetTrigger("onpos");
            }
        }
    }

    void FixedUpdate()
    {
        if (follow)
        {
            StartCoroutine(can());
        }
    }


    void OnMouseDown()
    {
        if (follow)
        {
            follow = false;
            canmove = false;
        }
        else if (mouse.mode == "choose")
        {
            follow = true;
            gotopoint = false;
            anim.SetTrigger("select");
            Debug.Log("select");
        }
    }

    public void GotoPoint(Vector3 x)
    {
        x.z = 0f;
        if (canmove)
        {
            follow = false;
            gotopoint = true;
            point = x;
        }     
    }

    IEnumerator can()
    {
        yield return new WaitForSeconds(1f);
        canmove = true;
    }
}
