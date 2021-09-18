using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredGear : Gear
{
    [SerializeField] private float speed = 250f;

    /// <summary>
    /// Use this to turn first gear in the chain.
    /// </summary>
    /// <param name="power">
    /// determines what % of default gear speed is used, and in what direction
    /// Positive clockwise, Negative anti-clockwise
    /// </param>
    public void RotateControl(float power)
    {
        //Rotate this gear
        Rotate(speed * power * Time.deltaTime);
    }

}
