using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenechangeUI : MonoBehaviour
{

    public GameObject scene1u ;
    public GameObject scene2u;
    public GameObject scene3u;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            scene1u.SetActive(false);
            scene2u.SetActive(false);
            scene3u.SetActive(false);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            scene1u.SetActive(true);
            scene2u.SetActive(false);
            scene3u.SetActive(false);
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            scene2u.SetActive(true);
            scene3u.SetActive(false);
            scene1u.SetActive(false);
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            scene3u.SetActive(true);
            scene1u.SetActive(false);
            scene2u.SetActive(false);
        }
    }
}
