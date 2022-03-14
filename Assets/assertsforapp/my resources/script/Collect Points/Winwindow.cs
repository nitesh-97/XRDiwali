using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winwindow : MonoBehaviour
{
    public GameObject menubutton;
    // Start is called before the first frame update
    private void OnEnable()
    {
        
        menubutton.SetActive(false);
    }
    private void OnDisable()
    {

        menubutton.SetActive(true);
    }

    
}
