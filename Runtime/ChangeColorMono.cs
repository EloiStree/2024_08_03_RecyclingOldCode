using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorMono : MonoBehaviour
{
    public void SwitchColor()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }

    public void Start()
    {
        SwitchColor();
    }
}
