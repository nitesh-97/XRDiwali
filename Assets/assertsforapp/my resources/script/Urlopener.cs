﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Urlopener : MonoBehaviour
{
    // Start is called before the first frame update
    public string Url;
    public void Open()
    {
        Application.OpenURL(Url);
    }
}
