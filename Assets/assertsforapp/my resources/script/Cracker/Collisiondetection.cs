using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondetection : MonoBehaviour
{
    public GameObject cracker;
    public GameObject cracker2;
    public GameObject igniterobj;
    public GameObject starprefab;
    public void OnParticleCollision(GameObject other)
    {
        Debug.Log("collision successful");
        starprefab.SetActive(true);
        igniterobj.SetActive(false);
        cracker.SetActive(true);
        cracker2.SetActive(true);
    }
}
