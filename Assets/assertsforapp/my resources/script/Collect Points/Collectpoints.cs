using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectpoints : MonoBehaviour
{
    //public GameObject Crackerb;
    public void OnCollisionEnter(Collision collision)
    {
        Scoreboard.thescore += 50;
        Destroy(gameObject);
    }
   // public void oncollisionenter
   // {
     //   Scoreboard.thescore += 50;
      //  Destroy(gameObject);
   // }
}
