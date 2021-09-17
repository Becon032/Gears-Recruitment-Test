using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerGear : MonoBehaviour
{
    public float speed = 50f;
    Gear mainGear;

    private void Start()
    {
        mainGear = GetComponent<Gear>();
    }

    private void Update()
    {
        if (speed != 0)
            PowerRotate();

    }

    private void PowerRotate()
    {
        float rotation = speed * mainGear.ToothCount * Time.deltaTime;
        mainGear.Rotate(rotation);
    }
}
