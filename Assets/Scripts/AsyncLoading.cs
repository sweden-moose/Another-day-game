using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncLoading : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadSceneAsync(index);
    }

}
