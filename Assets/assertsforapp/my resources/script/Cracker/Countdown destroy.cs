using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdowndestroy : MonoBehaviour
{
    public float interval;
    public GameObject crackerig;
    public TMP_Text win;
    public TMP_Text timetext;
    public float timestart;
    void Start()
    {
        Destroy(gameObject, interval);
        Destroy(crackerig, interval);
    }

    // Update is called once per frame
    void Update()
    {
        timestart -= Time.deltaTime;
        timetext.text = Mathf.Round(timestart).ToString();
        if (timestart <= 0)
        {
            timestart += Time.deltaTime;
            win.text = "gameover";
        }
    }
}
