using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadscenebutton : MonoBehaviour
{
    [SerializeField]
    private string scenetoload;
    private void Awake()
    {
        //GetComponent<ButtonActionManager>().onClick.AddListner(LoadScene);
    }
    public void LoadScene()
    {
        gameObject.SetActive(false);
        FindObjectOfType<LevelLoader>().LoadScene(scenetoload);
    }
}
