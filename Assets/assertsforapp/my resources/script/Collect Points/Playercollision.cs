using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Playercollision : MonoBehaviour
{
    public TMP_Text hittext;

    public void OnParticleCollision(GameObject other)
    {
        hittext.text = "Warning !";
        Debug.Log(" cracker collided ");
        Scoreboard.thescore -= 1;

    }

    
}
