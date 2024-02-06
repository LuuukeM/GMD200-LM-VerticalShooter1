using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixres : MonoBehaviour
{
    public GameObject FixResolution;

    public void fixResolution()
    {
        Screen.SetResolution(1920, 1080, true);
    }
}
