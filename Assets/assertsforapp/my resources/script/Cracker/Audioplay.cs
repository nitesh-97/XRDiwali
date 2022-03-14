using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioplay : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    [SerializeField]
    private float delayed = 0;
    public float replaytime;
    //[SerializeField]
    private float endtime2 = 0;
    void Start()
    {
        InvokeRepeating("Playaud", delayed, replaytime);
        
    }
    public void Playaud()
    {
        audioSource.Play();
    }
    public void Update()
    {
        endtime2 += Time.deltaTime;
        if(endtime2 >= delayed + 30)
        {
            CancelInvoke("Playaud");
        }
    }
    // Update is called once per frame

}
