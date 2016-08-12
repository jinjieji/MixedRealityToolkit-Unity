﻿using UnityEngine;

public class SphereKeywords : MonoBehaviour
{
    public void ChangeColor(string color)
    {
        switch(color.ToLower())
        {
            case "red":
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case "blue":
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "green":
                GetComponent<Renderer>().material.color = Color.green;
                break;
        }
    }
}