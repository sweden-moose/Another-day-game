using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogSystem : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;
    public GameObject button;
    public GameObject sc;
    private int index;
    private bool end;
    // Start is called before the first frame update
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
        button.SetActive(false);
        if(index < sentences.Length-1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            SceneChanger fg = sc.GetComponent<SceneChanger>();
            fg.change_without();
            button.SetActive(false);
        }
    }
    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            button.SetActive(true);
        }
    }
}
