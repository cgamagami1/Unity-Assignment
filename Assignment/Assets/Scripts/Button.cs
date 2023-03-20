/* (Colin Gamagami)
 * (Button.cs)
 * (Assignment 7)
 * (Defines a switchable button)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, Switchable
{
    private bool isSwitchedOn = false;
    public Material red;
    public Material green;
    private MeshRenderer mesh;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    public bool GetIsSwitchOn()
    {
        return isSwitchedOn;
    }

    public void SwitchOff()
    {
        isSwitchedOn = false;
    }

    public void SwitchOn()
    {
        isSwitchedOn = true;
    }

    public void Update()
    {
        if (isSwitchedOn)
        {
            mesh.material = green;
        }
        else
        {
            mesh.material = red;
        }
    }
}
