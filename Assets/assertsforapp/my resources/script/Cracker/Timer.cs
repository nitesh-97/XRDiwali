using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public static float timestart;
    public TMP_Text timebox;
    public GameObject crackerpr;
    public TMP_Text textbox2;
    void Start()
    {
        timebox.text = timestart.ToString();
        timestart = 3000;
    }

    // Update is called once per frame
    void Update()
    {
        timestart -= Time.deltaTime;
        timebox.text = Mathf.Round(timestart/10).ToString();
        if(timestart <= 50)
        {
            timestart += Time.deltaTime;
            textbox2.text = "Destroyed";
            Destroy(crackerpr, 0f);
        }
    }
}
