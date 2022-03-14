using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro2scene : MonoBehaviour
{
    // Start is called before the first frame update
    public int sscene2;
    void Start()
    {
        Invoke("Scchange2", 7f);
    }

    // Update is called once per frame
    void Scchange2()
    {
        SceneManager.LoadScene(sscene2);
    }
}
