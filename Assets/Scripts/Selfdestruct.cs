using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selfdestruct : MonoBehaviour
{
    public float interval;
    public GameObject crackerig;
    void Start()
    {
        //Destroy(gameObject, interval);
        Destroy(crackerig, interval);
    }

}
