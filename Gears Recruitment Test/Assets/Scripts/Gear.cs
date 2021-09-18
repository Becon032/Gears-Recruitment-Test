using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    [SerializeField] private float toothCount;
    [SerializeField] private List<Gear> childGearList;

    private void Start()
    {
        //Check for valid tooth count
        if (toothCount < 1)
        {
            Debug.LogError("Gear has invalid tooth count: " + toothCount, this);
            return;
        }
    }


    protected void Rotate(float rotation)
    {   
        //If this is first gear that it powered - ignore toothcount
        if (!(this is PoweredGear))
            rotation /= toothCount;

        //Rotate gear
        transform.Rotate(Vector3.up * rotation);

        //Run this same function for all of the child gears
        foreach (Gear item in childGearList)
        {
            if (item != this)
                item.Rotate(toothCount * -rotation);
            
        }
    }
}
