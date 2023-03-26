/*
 * (Colin Gamagami)
 * (Rocket.cs)
 * (Assignment 8)
 * (Implements the abstract rocket)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Rocket : MonoBehaviour
{
    private Rigidbody rb;
    protected MeshRenderer mesh;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
    }

    public void TakeOff()
    {
        MoveUp();

        if (IsGreen())
        {
            MakeGreen();
        }

        if (IsBlue())
        {
            MakeBlue();
        }
    }

    public void MoveUp()
    {
        rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }

    public abstract void MakeGreen();
    public abstract void MakeBlue();

    public virtual bool IsGreen() 
    { 
        return true; 
    }

    public virtual bool IsBlue()
    {
        return true;
    }
}
