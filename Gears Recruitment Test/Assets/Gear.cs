using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public float ToothCount;
    [SerializeField] Gear childGear;

    public void Rotate(float rotation)
    {
        rotation /= ToothCount;
        transform.Rotate(Vector3.up * rotation);

        if (childGear != null && childGear != this)
            childGear.Rotate(ToothCount * -rotation);

    }
}
