using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pwinlose : MonoBehaviour
{
    public GameObject wintex;
    public GameObject losetex;
    public static float counttime = 120;
    public TMP_Text countimetext;

    // Start is called before the first frame update
    private void Start()
    {
        counttime = 120;
    }

    // Update is called once per frame
    void Update()
    {
        if (counttime >= 2)
        {
            counttime -= Time.deltaTime;
            countimetext.text = " Countdown :" + Mathf.Round(counttime).ToString();
        }
        if (counttime <= 2)
        {
            counttime = 0;
        }
        if (Scoreboard.thescore == 400 && counttime>=2)
        {
            wintex.SetActive(true);
        }
        if (Scoreboard.thescore < 400 && counttime <= 3)
        {
            losetex.SetActive(true);
        }
    }
}
