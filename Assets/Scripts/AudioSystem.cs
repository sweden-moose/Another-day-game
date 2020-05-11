using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioSystem : MonoBehaviour
{
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        if (AudioListener.volume == 0)
        {
            img.color = new Color(255f, 0f, 0f, 255f);

        }
        else
        {
            img.color = new Color(0f, 191f, 0f, 255f);
        }

    }
   
    public void Music()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
            img.color = new Color(0f,191f,0f,255f);
        }
        else
        {
            AudioListener.volume = 0;
            img.color = new Color(255f, 0f, 0f, 255f);
        }
    }
}
