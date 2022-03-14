using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introscenen : MonoBehaviour
{
    // Start is called before the first frame update
   // public int iscene;
   // public int sscene;
    //public GameObject etobj;
    void Start()
    {
        //etobj.SetActive (false);
       // SceneManager.LoadScene(iscene);
       // Destroy(etobj);
       // Invoke("Scchange", 7f);
    }

    // Update is called once per frame
    public void Scchange(int sscene)
    {
        SceneManager.LoadScene(sscene);
    }
}
