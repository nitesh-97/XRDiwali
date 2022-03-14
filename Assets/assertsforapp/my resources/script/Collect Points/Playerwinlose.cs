using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Playerwinlose : MonoBehaviour
{
    public  GameObject wintext;
    public GameObject losetext;
    public TMP_Text elapsedtime;
    public static float gametime = 300;
    public float playtime;


    // Start is called before the first frame update
    void Start()
    {
        gametime = playtime ;
        elapsedtime.text ="Time Elapsed" + gametime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (gametime > 0)
        {
            gametime -= Time.deltaTime;
            elapsedtime.text = "Countdown : " + Mathf.Round(gametime).ToString();
           // elapsedtime.text = "Total Time : 500 " + 
           //  "Time Elapsed :" + Mathf.Round(gametime).ToString();
        }
        if (gametime <= 0)
        {
            gametime = 0;
            elapsedtime.text = "Game Over ";
        }

        if(Scoreboard.thescore >=550 && gametime>1 )
        {
            Win();
        }
        else if(Scoreboard.thescore <=550 && gametime==0)
        {
            Lose();
        }
    }
    public void Win()
    {
        wintext.SetActive(true);
    }
    public void Lose()
    {
        losetext.SetActive(true);
    }

}
