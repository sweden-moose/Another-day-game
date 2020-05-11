using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Animator trasitions;
    public Animator audio;
    public string sceneName;
    public GameObject image;
    public GameObject last;
    private bool canstart = false;

    public void change(string scenName)
    {
        sceneName = scenName;
        image.transform.localScale = new Vector3(1f, 1f, 1f);
        canstart = true;
    }

    public void change_without()
    {
        image.transform.localScale = new Vector3(1f, 1f, 1f);
        canstart = true;
    }
    

    void FixedUpdate()
    {
        if (canstart)
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        trasitions.SetTrigger("end");
        try
        {audio.SetTrigger("end");}
        catch { }
        yield return new WaitForSeconds(3f);
        canstart = false;
        last.SetActive(true);
        Debug.Log("last");
        trasitions.SetTrigger("endoftheend");
        SceneManager.LoadScene(sceneName);
    }


}
