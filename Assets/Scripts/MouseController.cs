using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{
    public Camera cam;
    public Image bar;
    public GameObject tuttext;
    public GameObject backgr;
    public List<GameObject> boxes = new List<GameObject>();
    private bool isclicked = false;
    private bool canclick = true;
    private float num = 1f;
    public string mode = "light";
    Ray ray;
    RaycastHit hit;

    void Start()
    {
        bar.fillAmount = num;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (mode == "light")
            {
                try { tuttext.SetActive(false); } catch { }
                    

                mode = "choose";
                backgr.SetActive(false);
            }
            else
            {
                try { tuttext.SetActive(true); } catch { }
                mode = "light";
                backgr.SetActive(true);
            }
        }
        if (Input.GetMouseButtonDown(0) && mode == "light")
        {
            if (canclick)
            {
                isclicked = true;
            }

        }
        else if (Input.GetMouseButtonDown(0) && mode == "choose")
        {
            var point = cam.ScreenToWorldPoint(Input.mousePosition);
            for (int i=0; i < boxes.Count; i++)
            {
                var NPC = boxes[i].GetComponent<PlayerFollow>();
                if (NPC.follow == true)
                {
                    NPC.GotoPoint(point);
                }
            }
        }
            
    }

    void FixedUpdate()
    {
        if (isclicked)
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            if (num > 0.01f)
            {
                StartCoroutine(BackNum());
            }
            else
            {
                canclick = false;
                isclicked = false;
            }
            bar.fillAmount = num;
        }
        else
        {
            if (num < 0.99f)
            {
                StartCoroutine(Num());
            }
            else
            {
                canclick = true;
            }
            bar.fillAmount = num;
            gameObject.transform.localScale = new Vector3(0f, 0f, 0f);
        }
    }

        IEnumerator Mouse()
        {
            isclicked = true;
            yield return new WaitForSeconds(0.01f);
        }
        IEnumerator BackNum()
        {
        yield return new WaitForSeconds(0.02f);
           num -= 0.009f;
        }
        IEnumerator Num()
        {
            yield return new WaitForSeconds(0.01f);
            num += 0.009f;
        }
    
}