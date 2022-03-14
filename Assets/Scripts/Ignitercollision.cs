using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignitercollision : MonoBehaviour
{
    public GameObject cracker;
    public GameObject igniterobj;
    public void OnParticleCollision(GameObject other)
    {
        Debug.Log("ignited");
        igniterobj.SetActive(false);
        cracker.SetActive(true);
    }
}
