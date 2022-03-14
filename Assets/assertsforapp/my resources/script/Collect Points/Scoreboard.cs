using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public TMP_Text scoretext;
    public static int thescore;
    public void Start()
    {
        thescore = 0;
    }
    public void Update()
    {
        scoretext.text = "SCORE: " + thescore.ToString();
        
    }

}
