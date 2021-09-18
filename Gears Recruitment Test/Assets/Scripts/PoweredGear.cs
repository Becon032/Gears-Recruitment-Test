using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredGear : Gear
{
    [SerializeField] private float speed = 250f;

    /// <summary>
    /// Use this to turn first gear in the chain.
    /// </summary>
    /// <param name="handleOutput">Positive clockwise, Negative anti-clockwise</param>
    public void RotateControl(float handleOutput)
    {
        //Rotate this gear
        Rotate(speed * handleOutput * Time.deltaTime);
    }

}
